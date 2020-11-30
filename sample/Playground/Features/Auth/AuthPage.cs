using Playground.Common.Base;
using Playground.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Vm = Playground.Features.Auth.AuthViewModel;
using static Xamarin.Forms.Markup.GridRowsColumns;

namespace Playground.Features.Auth
{
    public sealed class AuthPage : ContentPageBase<Vm>
    {
        public AuthPage() => Build();

        private void Build()
        {
            InitializeViewModel();
            
            Content = new Grid {
                    RowDefinitions = Rows.Define(Star, Auto, Auto),
                    Children = {
                        new Label { TextColor = Color.Black }
                            .Row(0)
                            .Center()
                            .Bind(nameof(Vm.LoginText)),
                        new Button { Text = Localization.ButtonTextSignInWithEmail, TextColor = Color.Black }
                            .Row(1)
                            .FillHorizontal()
                            .Bottom()
                            .Bind(nameof(Vm.SignInWithEmailCommand)),
                        new Button { Text = Localization.ButtonTextSignOut, TextColor = Color.Black }
                            .Row(2)
                            .FillHorizontal()
                            .Bottom()
                            .Bind(nameof(Vm.SignOutCommand))
                    }
                }
                .Margin(24);
        }
    }
}