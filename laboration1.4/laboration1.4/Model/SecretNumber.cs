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

    [Serializable]
    public class SecretNumber
    {
        private int _number;
        private List<int> _previousGuesses;
        private const int MaxNumberOfGuesses = 6;

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
            Random random = new Random();

            int randomInt = random.Next(1, 101);

            this._number = randomInt;
            this._previousGuesses = new List<int>();
            this.CanMakeGuess = true;
        }

        public void Initialize()
        {
            Random random = new Random();

            int randomInt = random.Next(1, 101);

            this._number = randomInt;
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
                if (Count == MaxNumberOfGuesses)
                {
                    return Outcome.NoMoreGuesses;
                }

                for (int i = 0; i < Count; i++)
                {
                    if (guess == this._previousGuesses[i])
                    {
                        return Outcome.PreviousGuess;
                    }
                }


                if (guess == this._number)      // Korrekt
                {
                    return Outcome.Correct;
                }

                else if (guess > this._number)  // För högt
                {
                    this._previousGuesses.Add(guess);
                    // this._previousGuesses[Count] = guess;
                    Count++;
                    return Outcome.High;
                }

                else if (guess < this._number)  // För lågt
                {
                    this._previousGuesses.Add(guess);
                    //this._previousGuesses[Count] = guess;
                    Count++;
                    return Outcome.Low;
                }
            }
        
            else
            {
                throw new ArgumentOutOfRangeException();
            }

            return Outcome.Indefinite;
        }

    }
}