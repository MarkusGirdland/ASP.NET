using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace laboration1._4
{
    public enum Outcome
    {
        Indefinite,
        Low,
        High,
        Correct,
        NoMoreGuesses,
        PreviousGuess
    }

    public class SecretNumber
    {
        private int _number;
        private List<int> _previousGuesses;
        private const int MaxNumberOfGuesses = 7;

        public bool CanMakeGuess
        {
            get;
            set;
        }

        public int Count
        {
            get;
            set;
        }

        public int? Number()
        {
            if(CanMakeGuess)
            {
                return null;
            }

            else
            {
                return this._number;
            }
        }

        public Outcome Outcome
        {
            get;
            set;
        }

        public SecretNumber()
        {
            this._number = 75;
            this._previousGuesses = new List<int>();
            this._previousGuesses.Add(7);
        }

        public void Initialize()
        {
            this._number = 75;      //TODO: Slumpa
            this._previousGuesses.Clear();
        }

        public IReadOnlyCollection<int> PreviousGuesses()
        {
            return this._previousGuesses;
        }

        public Outcome MakeGuess(int guess)
        {
            if (guess > 0 && guess <= 100)
            {
                if (guess == this._number)      // Korrekt
                {
                    return Outcome.Correct;
                }

                else if (guess > this._number)  // För högt
                {
                    this._previousGuesses[Count] = guess;
                    Count++;
                    return Outcome.High;
                }

                else if (guess < this._number)  // För lågt
                {
                    this._previousGuesses[Count] = guess;
                    Count++;
                    return Outcome.Low;
                }

                else if (Count == MaxNumberOfGuesses)
                {
                    return Outcome.NoMoreGuesses;
                }

                else
                {
                    for (int i = 0; i < MaxNumberOfGuesses; i++)
                    {
                        if (guess == this._previousGuesses[i])
                        {
                            return Outcome.PreviousGuess;
                        }
                    }

                    return Outcome.Indefinite;
                }
            }

            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

    }
}