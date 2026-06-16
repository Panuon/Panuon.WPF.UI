# GlobalSettings 全局设置

## 小提示
1. `x:Key` 可以是任何名称（只要不与这里可能添加的其他内容重名）。
2. 定义多个资源字典时，需要通过`MergedDictionaries`方式将`pu:GlobalSettings`引入和其他资源字典进行合并，直接定义`pu:GlobalSettings`资源不会生效。  

## 属性
以下属性包含在辅助类*GlobalSettings*中。  

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| AnimationDuration | *TimeSpan* | *null* | 动画的持续时间。值为`null`或`0`时，不会执行动画效果。 |
| DisabledOpacity | *double* | *null* | 与控件或界面元素的禁用状态（如灰化效果）相关的透明度值。 |
| FontFamily | *FontFamily* | *null* | 字体家族。 |
| FontSize | *double* | *null* | 字体的大小。 |
| FocusVisualStyle | *Style* | *(见内部资源键)* | 控件在获得焦点时的视觉效果。 |
| IconFontFamily | *FontFamily* | *null* | 图标字体家族。 |
| IconFontSize | *double* | *null* | 图标字体的大小。 |

## 示例

```xml
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <pu:StyleDictionary Includes="All" />
                <ResourceDictionary>
                    <pu:GlobalSettings x:Key="globalSettings"
                                       FontSize="20"
                                       IconFontSize="20"
                                       IconFontFamily="{StaticResource PanuonIconFont}"/>
                </ResourceDictionary>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources> 
```

 