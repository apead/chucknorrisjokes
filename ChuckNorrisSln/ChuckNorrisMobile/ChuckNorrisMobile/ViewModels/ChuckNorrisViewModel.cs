using ChuckNorrisJokesLibrary;
using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace ChuckNorrisMobile.ViewModels
{
    public class ChuckNorrisViewModel : BaseViewModel
    {
        private string _joke;
        public string Joke
        {
            get { return _joke; }
            set { _joke = value;
                OnPropertyChanged("Joke");
            }
        }

        public ChuckNorrisViewModel()
        {
            Title = "Chuck Norris";

            ShowJokeCommand = new Command(ShowJoke);
        }

        public ICommand ShowJokeCommand { get; }

        public async void ShowJoke()
        {
            var jokeGenerator = new JokeGenerator();
            Joke = await jokeGenerator.GetRandomJoke();

        }
    }
}