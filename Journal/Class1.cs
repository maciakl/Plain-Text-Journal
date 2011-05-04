// Shamelessly stolen from StackOverflow question: http://stackoverflow.com/questions/4024798/trying-to-use-the-c-spellcheck-class

using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms.Integration;
using System.Windows.Forms.Design;

[Designer(typeof(ControlDesigner))]
//[DesignerSerializer("System.Windows.Forms.Design.ControlCodeDomSerializer, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
class SpellBox : ElementHost
{

    private TextBox box;

    public SpellBox()
    {
        box = new TextBox();
        base.Child = box;
        box.TextChanged += (s, e) => OnTextChanged(EventArgs.Empty);
        box.SpellCheck.IsEnabled = true;
        box.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
        this.Size = new System.Drawing.Size(100, 20);
        box.AcceptsReturn = true;
        box.AcceptsTab = true;
        box.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;

        
    }
    public override string Text
    {
        get { return box.Text; }
        set { box.Text = value; }
    }
    [DefaultValue(false)]
    public bool Multiline
    {
        get { return box.AcceptsReturn; }
        set { box.AcceptsReturn = value; }
    }
    [DefaultValue(false)]
    public bool WordWrap
    {
        get { return box.TextWrapping != TextWrapping.NoWrap; }
        set { box.TextWrapping = value ? TextWrapping.Wrap : TextWrapping.NoWrap; }
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new System.Windows.UIElement Child
    {
        get { return base.Child; }
        set { /* Do nothing to solve a problem with the serializer !! */ }
    }
    
    // Grafting on KeyUp handling onto this fake box
    public System.Windows.Input.KeyEventHandler KeyUp1 // can't be named KeyUp so we do the next best thing
    {
        get { return null; } // apparently you need a getter property here, so we put a fake one in
        set { if(value != null) box.KeyUp += value; } // stupid designer initializes this to null so we check for that
    }

    
}
