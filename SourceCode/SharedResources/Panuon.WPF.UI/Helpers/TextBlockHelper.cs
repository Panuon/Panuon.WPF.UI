using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public static class TextBlockHelper
    {
        #region Properties

        #region HighlightText
        public static string GetHighlightText(TextBlock textBlock)
        {
            return (string)textBlock.GetValue(HighlightTextProperty);
        }

        public static void SetHighlightText(TextBlock textBlock, string value)
        {
            textBlock.SetValue(HighlightTextProperty, value);
        }

        public static readonly DependencyProperty HighlightTextProperty =
            DependencyProperty.RegisterAttached("HighlightText", typeof(string), typeof(TextBlockHelper), new PropertyMetadata(OnHighlightTextChanged));
        #endregion

        #region HighlightRegex
        public static string GetHighlightRegex(TextBlock textBlock)
        {
            return (string)textBlock.GetValue(HighlightRegexProperty);
        }

        public static void SetHighlightRegex(TextBlock textBlock, string value)
        {
            textBlock.SetValue(HighlightRegexProperty, value);
        }

        public static readonly DependencyProperty HighlightRegexProperty =
            DependencyProperty.RegisterAttached("HighlightRegex", typeof(string), typeof(TextBlockHelper), new PropertyMetadata(OnHighlightTextChanged));
        #endregion

        #region HighlightRule
        public static HighlightRule GetHighlightRule(TextBlock textBlock)
        {
            return (HighlightRule)textBlock.GetValue(HighlightRuleProperty);
        }

        public static void SetHighlightRule(TextBlock textBlock, HighlightRule value)
        {
            textBlock.SetValue(HighlightRuleProperty, value);
        }

        public static readonly DependencyProperty HighlightRuleProperty =
            DependencyProperty.RegisterAttached("HighlightRule", typeof(HighlightRule), typeof(TextBlockHelper), new PropertyMetadata(HighlightRule.All, OnHighlightTextChanged));
        #endregion

        #region HighlightForeground
        public static Brush GetHighlightForeground(TextBlock textBlock)
        {
            return (Brush)textBlock.GetValue(HighlightForegroundProperty);
        }

        public static void SetHighlightForeground(TextBlock textBlock, Brush value)
        {
            textBlock.SetValue(HighlightForegroundProperty, value);
        }

        public static readonly DependencyProperty HighlightForegroundProperty =
            DependencyProperty.RegisterAttached("HighlightForeground", typeof(Brush), typeof(TextBlockHelper), new PropertyMetadata(Brushes.Red, OnHighlightTextChanged));
        #endregion

        #region HighlightBackground
        public static Brush GetHighlightBackground(TextBlock textBlock)
        {
            return (Brush)textBlock.GetValue(HighlightBackgroundProperty);
        }

        public static void SetHighlightBackground(TextBlock textBlock, Brush value)
        {
            textBlock.SetValue(HighlightBackgroundProperty, value);
        }

        public static readonly DependencyProperty HighlightBackgroundProperty =
            DependencyProperty.RegisterAttached("HighlightBackground", typeof(Brush), typeof(TextBlockHelper), new PropertyMetadata(null, OnHighlightTextChanged));

        #endregion

        #endregion

        #region Internal Properties

        #region Text
        internal static string GetText(TextBlock textBlock)
        {
            return (string)textBlock.GetValue(TextProperty);
        }

        internal static void SetText(TextBlock textBlock, string value)
        {
            textBlock.SetValue(TextProperty, value);
        }

        internal static readonly DependencyProperty TextProperty =
            DependencyProperty.RegisterAttached("Text", typeof(string), typeof(TextBlockHelper), new PropertyMetadata(OnHighlightTextChanged));
        #endregion

        #region IsRegisted
        internal static bool GetIsRegisted(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsRegistedProperty);
        }

        internal static void SetIsRegisted(DependencyObject obj, bool value)
        {
            obj.SetValue(IsRegistedProperty, value);
        }

        internal static readonly DependencyProperty IsRegistedProperty =
            DependencyProperty.RegisterAttached("IsRegisted", typeof(bool), typeof(TextBlockHelper));
        #endregion

        #endregion

        #region Event Handler
        private static void OnHighlightTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var textBlock = d as TextBlock;
            if (textBlock == null)
            {
                return;
            }
            if (!GetIsRegisted(textBlock))
            {
                textBlock.SetBinding(TextProperty, new Binding()
                {
                    Path = new PropertyPath(TextBlock.TextProperty),
                    Source = textBlock,
                    UpdateSourceTrigger = UpdateSourceTrigger.Default,
                    Mode = BindingMode.OneWay,
                });
                SetIsRegisted(textBlock, true);
            }

            var text = GetText(textBlock);
            var regex = GetHighlightRegex(textBlock);
            var highlightText = GetHighlightText(textBlock);
            var foreground = GetHighlightForeground(textBlock);
            var background = GetHighlightBackground(textBlock);
            var rule = GetHighlightRule(textBlock);

            if (string.IsNullOrEmpty(text)
                || (string.IsNullOrEmpty(highlightText) && string.IsNullOrEmpty(regex)))
            {
                textBlock.Inlines.Clear();
                textBlock.Inlines.Add(new Run(text));
                return;
            }

            if (!string.IsNullOrEmpty(regex))
            {
                var match = Regex.Match(text, regex);
                var index = match.Index;
                var matchText = match.Value;
                if (string.IsNullOrEmpty(matchText))
                {
                    textBlock.Inlines.Clear();
                    textBlock.Inlines.Add(new Run(text));
                    return;
                }

                textBlock.Inlines.Clear();

                while (true)
                {
                    textBlock.Inlines.AddRange(new Inline[]
                    {
                        new Run(text.Substring(0, index)),
                        new Run(text.Substring(index, matchText.Length))
                        {
                            Background = background ?? null,
                            Foreground = foreground ?? textBlock.Foreground
                        }
                    });

                    text = text.Substring(index + matchText.Length);
                    match = Regex.Match(text, regex);
                    index = match.Index;
                    matchText = match.Value;

                    if (string.IsNullOrEmpty(matchText)
                        || rule == HighlightRule.FirstOnly)
                    {
                        textBlock.Inlines.Add(new Run(text));
                        break;
                    }
                }
            }
            else if (!string.IsNullOrEmpty(text))
            {
                var index = text.IndexOf(highlightText, StringComparison.CurrentCultureIgnoreCase);
                if (index < 0)
                {
                    textBlock.Inlines.Clear();
                    textBlock.Inlines.Add(new Run(text));
                    return;
                }

                textBlock.Inlines.Clear();

                while (true)
                {
                    textBlock.Inlines.AddRange(new Inline[]
                    {
                        new Run(text.Substring(0, index)),
                        new Run(text.Substring(index, highlightText.Length))
                        {
                            Background = background ?? null,
                            Foreground = foreground ?? textBlock.Foreground
                        }
                    });

                    text = text.Substring(index + highlightText.Length);
                    index = text.IndexOf(highlightText, StringComparison.CurrentCultureIgnoreCase);

                    if (index < 0 || rule == HighlightRule.FirstOnly)
                    {
                        textBlock.Inlines.Add(new Run(text));
                        break;
                    }
                }
            }
        }
        #endregion

    }
}
