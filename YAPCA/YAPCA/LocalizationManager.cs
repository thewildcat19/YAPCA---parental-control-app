using System.Windows.Forms;
using YAPCA.res;

namespace YAPCA;

public class LocalizationManager
{
    public static void SetLanguage(string langCode)
    {
        System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo(langCode);
        System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
        System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
        LocalizeForms();
    }

    private static void LocalizeForms()
    {
        foreach (Form form in Application.OpenForms)
        {
            LocalizeUiElements(form);
        }
    }

    public static void LocalizeUiElements(Form form)
    {
        foreach (Control control in form.Controls)
        {
            LocalizeControl(control);
        }
    }
    private static void LocalizeControl(Control control)
    {
        
        if (!string.IsNullOrEmpty(control.Name))
        {
            string? localizedText = Resources.ResourceManager.GetString(control.Name);
            if (!string.IsNullOrEmpty(localizedText))
            {
                control.Text = localizedText;
            }
        }

        if (control is TabControl tabControl)
        {
            foreach (Control childControl in tabControl.Controls)
            {
                LocalizeControl(childControl);
            }
        }

        foreach (Control childControl in control.Controls)
        {
            LocalizeControl(childControl);  
        }
    }

    
}