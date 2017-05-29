using System;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace MvvmCross_Application1.Core.ViewModels {
  public class SecondViewModel : MvxViewModel<string> {
    string test = "this shouldn't be displayed";

    public SecondViewModel() {

    }

    public string Test {
      get { return test; }
    }

    public override Task Initialize(string parameter) {
      test = parameter;
      return Task.FromResult(0);
    }
  }
}
