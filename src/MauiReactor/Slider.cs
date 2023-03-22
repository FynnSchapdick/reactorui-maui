// <auto-generated />
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using MauiReactor.Animations;
using MauiReactor.Shapes;
using MauiReactor.Internals;

#nullable enable
namespace MauiReactor
{
    public partial interface ISlider : IView
    {
        PropertyValue<double>? Minimum { get; set; }

        PropertyValue<double>? Maximum { get; set; }

        PropertyValue<double>? Value { get; set; }

        PropertyValue<Microsoft.Maui.Graphics.Color>? MinimumTrackColor { get; set; }

        PropertyValue<Microsoft.Maui.Graphics.Color>? MaximumTrackColor { get; set; }

        PropertyValue<Microsoft.Maui.Graphics.Color>? ThumbColor { get; set; }

        PropertyValue<Microsoft.Maui.Controls.ImageSource>? ThumbImageSource { get; set; }

        Action? ValueChangedAction { get; set; }

        Action<object?, ValueChangedEventArgs>? ValueChangedActionWithArgs { get; set; }

        Action? DragStartedAction { get; set; }

        Action<object?, EventArgs>? DragStartedActionWithArgs { get; set; }

        Action? DragCompletedAction { get; set; }

        Action<object?, EventArgs>? DragCompletedActionWithArgs { get; set; }
    }

    public partial class Slider<T> : View<T>, ISlider where T : Microsoft.Maui.Controls.Slider, new()
    {
        public Slider()
        {
        }

        public Slider(Action<T?> componentRefAction) : base(componentRefAction)
        {
        }

        PropertyValue<double>? ISlider.Minimum { get; set; }

        PropertyValue<double>? ISlider.Maximum { get; set; }

        PropertyValue<double>? ISlider.Value { get; set; }

        PropertyValue<Microsoft.Maui.Graphics.Color>? ISlider.MinimumTrackColor { get; set; }

        PropertyValue<Microsoft.Maui.Graphics.Color>? ISlider.MaximumTrackColor { get; set; }

        PropertyValue<Microsoft.Maui.Graphics.Color>? ISlider.ThumbColor { get; set; }

        PropertyValue<Microsoft.Maui.Controls.ImageSource>? ISlider.ThumbImageSource { get; set; }

        Action? ISlider.ValueChangedAction { get; set; }

        Action<object?, ValueChangedEventArgs>? ISlider.ValueChangedActionWithArgs { get; set; }

        Action? ISlider.DragStartedAction { get; set; }

        Action<object?, EventArgs>? ISlider.DragStartedActionWithArgs { get; set; }

        Action? ISlider.DragCompletedAction { get; set; }

        Action<object?, EventArgs>? ISlider.DragCompletedActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();
            Validate.EnsureNotNull(NativeControl);
            var thisAsISlider = (ISlider)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Slider.MinimumProperty, thisAsISlider.Minimum);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Slider.MaximumProperty, thisAsISlider.Maximum);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Slider.ValueProperty, thisAsISlider.Value);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Slider.MinimumTrackColorProperty, thisAsISlider.MinimumTrackColor);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Slider.MaximumTrackColorProperty, thisAsISlider.MaximumTrackColor);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Slider.ThumbColorProperty, thisAsISlider.ThumbColor);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Slider.ThumbImageSourceProperty, thisAsISlider.ThumbImageSource);
            base.OnUpdate();
            OnEndUpdate();
        }

        protected override void OnAnimate()
        {
            OnBeginAnimate();
            var thisAsISlider = (ISlider)this;
            AnimateProperty(Microsoft.Maui.Controls.Slider.MinimumProperty, thisAsISlider.Minimum);
            AnimateProperty(Microsoft.Maui.Controls.Slider.MaximumProperty, thisAsISlider.Maximum);
            AnimateProperty(Microsoft.Maui.Controls.Slider.ValueProperty, thisAsISlider.Value);
            base.OnAnimate();
            OnEndAnimate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();
        partial void OnBeginAnimate();
        partial void OnEndAnimate();
        partial void OnAttachingNativeEvents();
        partial void OnDetachingNativeEvents();
        protected override void OnAttachNativeEvents()
        {
            Validate.EnsureNotNull(NativeControl);
            var thisAsISlider = (ISlider)this;
            if (thisAsISlider.ValueChangedAction != null || thisAsISlider.ValueChangedActionWithArgs != null)
            {
                NativeControl.ValueChanged += NativeControl_ValueChanged;
            }

            if (thisAsISlider.DragStartedAction != null || thisAsISlider.DragStartedActionWithArgs != null)
            {
                NativeControl.DragStarted += NativeControl_DragStarted;
            }

            if (thisAsISlider.DragCompletedAction != null || thisAsISlider.DragCompletedActionWithArgs != null)
            {
                NativeControl.DragCompleted += NativeControl_DragCompleted;
            }

            OnAttachingNativeEvents();
            base.OnAttachNativeEvents();
        }

        private void NativeControl_ValueChanged(object? sender, ValueChangedEventArgs e)
        {
            var thisAsISlider = (ISlider)this;
            thisAsISlider.ValueChangedAction?.Invoke();
            thisAsISlider.ValueChangedActionWithArgs?.Invoke(sender, e);
        }

        private void NativeControl_DragStarted(object? sender, EventArgs e)
        {
            var thisAsISlider = (ISlider)this;
            thisAsISlider.DragStartedAction?.Invoke();
            thisAsISlider.DragStartedActionWithArgs?.Invoke(sender, e);
        }

        private void NativeControl_DragCompleted(object? sender, EventArgs e)
        {
            var thisAsISlider = (ISlider)this;
            thisAsISlider.DragCompletedAction?.Invoke();
            thisAsISlider.DragCompletedActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.ValueChanged -= NativeControl_ValueChanged;
                NativeControl.DragStarted -= NativeControl_DragStarted;
                NativeControl.DragCompleted -= NativeControl_DragCompleted;
            }

            OnDetachingNativeEvents();
            base.OnDetachNativeEvents();
        }
    }

    public partial class Slider : Slider<Microsoft.Maui.Controls.Slider>
    {
        public Slider()
        {
        }

        public Slider(Action<Microsoft.Maui.Controls.Slider?> componentRefAction) : base(componentRefAction)
        {
        }
    }

    public static partial class SliderExtensions
    {
        public static T Minimum<T>(this T slider, double minimum, RxDoubleAnimation? customAnimation = null)
            where T : ISlider
        {
            slider.Minimum = new PropertyValue<double>(minimum);
            slider.AppendAnimatable(Microsoft.Maui.Controls.Slider.MinimumProperty, customAnimation ?? new RxDoubleAnimation(minimum), v => slider.Minimum = new PropertyValue<double>(v.CurrentValue()));
            return slider;
        }

        public static T Minimum<T>(this T slider, Func<double> minimumFunc)
            where T : ISlider
        {
            slider.Minimum = new PropertyValue<double>(minimumFunc);
            return slider;
        }

        public static T Maximum<T>(this T slider, double maximum, RxDoubleAnimation? customAnimation = null)
            where T : ISlider
        {
            slider.Maximum = new PropertyValue<double>(maximum);
            slider.AppendAnimatable(Microsoft.Maui.Controls.Slider.MaximumProperty, customAnimation ?? new RxDoubleAnimation(maximum), v => slider.Maximum = new PropertyValue<double>(v.CurrentValue()));
            return slider;
        }

        public static T Maximum<T>(this T slider, Func<double> maximumFunc)
            where T : ISlider
        {
            slider.Maximum = new PropertyValue<double>(maximumFunc);
            return slider;
        }

        public static T Value<T>(this T slider, double value, RxDoubleAnimation? customAnimation = null)
            where T : ISlider
        {
            slider.Value = new PropertyValue<double>(value);
            slider.AppendAnimatable(Microsoft.Maui.Controls.Slider.ValueProperty, customAnimation ?? new RxDoubleAnimation(value), v => slider.Value = new PropertyValue<double>(v.CurrentValue()));
            return slider;
        }

        public static T Value<T>(this T slider, Func<double> valueFunc)
            where T : ISlider
        {
            slider.Value = new PropertyValue<double>(valueFunc);
            return slider;
        }

        public static T MinimumTrackColor<T>(this T slider, Microsoft.Maui.Graphics.Color minimumTrackColor)
            where T : ISlider
        {
            slider.MinimumTrackColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(minimumTrackColor);
            return slider;
        }

        public static T MinimumTrackColor<T>(this T slider, Func<Microsoft.Maui.Graphics.Color> minimumTrackColorFunc)
            where T : ISlider
        {
            slider.MinimumTrackColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(minimumTrackColorFunc);
            return slider;
        }

        public static T MaximumTrackColor<T>(this T slider, Microsoft.Maui.Graphics.Color maximumTrackColor)
            where T : ISlider
        {
            slider.MaximumTrackColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(maximumTrackColor);
            return slider;
        }

        public static T MaximumTrackColor<T>(this T slider, Func<Microsoft.Maui.Graphics.Color> maximumTrackColorFunc)
            where T : ISlider
        {
            slider.MaximumTrackColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(maximumTrackColorFunc);
            return slider;
        }

        public static T ThumbColor<T>(this T slider, Microsoft.Maui.Graphics.Color thumbColor)
            where T : ISlider
        {
            slider.ThumbColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(thumbColor);
            return slider;
        }

        public static T ThumbColor<T>(this T slider, Func<Microsoft.Maui.Graphics.Color> thumbColorFunc)
            where T : ISlider
        {
            slider.ThumbColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(thumbColorFunc);
            return slider;
        }

        public static T ThumbImageSource<T>(this T slider, Microsoft.Maui.Controls.ImageSource thumbImageSource)
            where T : ISlider
        {
            slider.ThumbImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(thumbImageSource);
            return slider;
        }

        public static T ThumbImageSource<T>(this T slider, Func<Microsoft.Maui.Controls.ImageSource> thumbImageSourceFunc)
            where T : ISlider
        {
            slider.ThumbImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(thumbImageSourceFunc);
            return slider;
        }

        public static T ThumbImageSource<T>(this T slider, string file)
            where T : ISlider
        {
            slider.ThumbImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromFile(file));
            return slider;
        }

        public static T ThumbImageSource<T>(this T slider, Func<string> action)
            where T : ISlider
        {
            slider.ThumbImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(() => Microsoft.Maui.Controls.ImageSource.FromFile(action()));
            return slider;
        }

        public static T ThumbImageSource<T>(this T slider, string resourceName, Assembly sourceAssembly)
            where T : ISlider
        {
            slider.ThumbImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromResource(resourceName, sourceAssembly));
            return slider;
        }

        public static T ThumbImageSource<T>(this T slider, Uri imageUri)
            where T : ISlider
        {
            slider.ThumbImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromUri(imageUri));
            return slider;
        }

        public static T ThumbImageSource<T>(this T slider, Uri imageUri, bool cachingEnabled, TimeSpan cacheValidity)
            where T : ISlider
        {
            slider.ThumbImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(new UriImageSource{Uri = imageUri, CachingEnabled = cachingEnabled, CacheValidity = cacheValidity});
            return slider;
        }

        public static T ThumbImageSource<T>(this T slider, Func<Stream> imageStream)
            where T : ISlider
        {
            slider.ThumbImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromStream(imageStream));
            return slider;
        }

        public static T OnValueChanged<T>(this T slider, Action? valueChangedAction)
            where T : ISlider
        {
            slider.ValueChangedAction = valueChangedAction;
            return slider;
        }

        public static T OnValueChanged<T>(this T slider, Action<object?, ValueChangedEventArgs>? valueChangedActionWithArgs)
            where T : ISlider
        {
            slider.ValueChangedActionWithArgs = valueChangedActionWithArgs;
            return slider;
        }

        public static T OnDragStarted<T>(this T slider, Action? dragStartedAction)
            where T : ISlider
        {
            slider.DragStartedAction = dragStartedAction;
            return slider;
        }

        public static T OnDragStarted<T>(this T slider, Action<object?, EventArgs>? dragStartedActionWithArgs)
            where T : ISlider
        {
            slider.DragStartedActionWithArgs = dragStartedActionWithArgs;
            return slider;
        }

        public static T OnDragCompleted<T>(this T slider, Action? dragCompletedAction)
            where T : ISlider
        {
            slider.DragCompletedAction = dragCompletedAction;
            return slider;
        }

        public static T OnDragCompleted<T>(this T slider, Action<object?, EventArgs>? dragCompletedActionWithArgs)
            where T : ISlider
        {
            slider.DragCompletedActionWithArgs = dragCompletedActionWithArgs;
            return slider;
        }
    }
}