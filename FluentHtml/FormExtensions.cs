using System;
using FluentHtml.Element;
using FluentHtml.Form;

namespace FluentHtml
{
    public static class FormExtensions
    {
        public static TParentElement AddForm<TParentElement>(this TParentElement parent, Action<FormElement> form)
            where TParentElement : BaseContentElement
        {
            FormElement element = new FormElement();
            parent.AddChild(element);
            form(element);
            return parent;
        }

        public static TParentElement AddLabel<TParentElement>(this TParentElement parent, Action<LabelElement> label)
            where TParentElement : BaseContentElement
        {
            LabelElement element = new LabelElement();
            parent.AddChild(element);
            label(element);
            return parent;
        }

        public static TParentElement AddButton<TParentElement>(this TParentElement parent, Action<ButtonElement> button)
            where TParentElement : BaseContentElement
        {
            ButtonElement element = new ButtonElement();
            parent.AddChild(element);
            button(element);
            return parent;
        }

        public static TParentElement AddInput<TParentElement>(this TParentElement parent, InputType type, Action<InputElement> input)
            where TParentElement : BaseContentElement
        {
            InputElement element = new InputElement(type);
            parent.AddChild(element);
            input(element);
            return parent;
        }

        public static TParentElement AddInput<TParentElement>(this TParentElement parent, string type, Action<InputElement> input)
            where TParentElement : BaseContentElement
        {
            InputElement element = new InputElement(type);
            parent.AddChild(element);
            input(element);
            return parent;
        }

        public static TParentElement AddSelect<TParentElement>(this TParentElement parent, Action<SelectElement> select)
            where TParentElement : BaseContentElement
        {
            SelectElement element = new SelectElement();
            parent.AddChild(element);
            select(element);
            return parent;
        }
    }
}