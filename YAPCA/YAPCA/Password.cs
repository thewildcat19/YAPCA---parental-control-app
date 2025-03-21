namespace YAPCA;

public static class Password
{
    public static bool CheckPassword()
    {
        using (var form = new LoginWindow())
        {
            return form.ShowDialog() == DialogResult.OK;
        }
    }
}