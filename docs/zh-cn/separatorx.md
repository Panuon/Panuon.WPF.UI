# SeparatorX 分割线

## 属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| Orientation | *Orientation* | *Horizontal* | 排列方向。`Horizontal`表示水平排列，`Vertical`表示垂直排列。 | 
| Stroke | *Brush* | *null* | 分割线的颜色。 | 
| StrokeDashArray | *DoubleCollection* | *null* | 虚线时，线段和空白段之间的距离。 | 
| StrokeDashCap | *PenLineCap* | *Flat* | 虚线时的端点样式。`Flat`表示平坦。`Round`表示圆滑。`Square`表示方形，与`Flat`类似，但边缘是方形。`Triangle`表示三角形。 | 
| StrokeDashOffset | *double* | *null* | 起始偏移量。 | 
| StrokeLineCap | *PenLineCap* | *Flat* | 线条时的端点样式。`Flat`表示平坦。`Round`表示圆滑。`Square`表示方形，与`Flat`类似，但边缘是方形。`Triangle`表示三角形。 | 
| StrokeThickness | *double* | *(自动计算)* | 线条的粗细。 | 


## 示例

### 示例1
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/separatorx-1-_theme_.png"></img>

```xml
<pu:SeparatorX           
    Orientation="Horizontal"
    Stroke="Red"
    StrokeDashArray="2"
    StrokeDashCap="Triangle"
    StrokeDashOffset="3"
    StrokeThickness="5" />
```




