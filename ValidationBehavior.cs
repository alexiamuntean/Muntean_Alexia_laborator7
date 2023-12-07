using Muntean_Alexia_laborator7.Models;
namespace Muntean_Alexia_laborator7
{
    class ValidationBehavior : Behavior <Editor>
    {
        protected override void OnAttachedTo(Editor entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }
        protected override void OnDetachingFrom(Editor entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }
        void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            ((Editor)sender).BackgroundColor = string.IsNullOrEmpty(args.NewTextValue) ? Color.FromRgba("#AA4A44") :Color.FromRgba("#FFFFFF");
        }
    }

}
