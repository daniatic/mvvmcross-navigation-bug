using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace MvvmCross_Application1.Core.ViewModels {
  public class FirstViewModel : MvxViewModel {
    public FirstViewModel(IMvxNavigationService navigation) {
      navigationService = navigation;
    }

    private IMvxNavigationService navigationService;
    private IMvxAsyncCommand navigateCommand;
    public IMvxAsyncCommand NavigateCommand {
      get {
        navigateCommand = navigateCommand ?? new MvxAsyncCommand(() => navigationService.Navigate<SecondViewModel, string>("test"));
        return navigateCommand;
      }
    }
  }
}
