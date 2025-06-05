using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibraryDA.Classes
{
    public class Balance
    {
        public float Amount { get; set; }
        public bool CanBeChanged { get; set; } = true;

        public Balance(float initialAmount = 0)
        {
            Amount = initialAmount;
        }

        public void Increase(float amount)
        {
            if (!CanBeChanged)
                throw new InvalidOperationException("Balance is frozen and cannot be changed.");

            if (amount < 0)
                throw new ArgumentException("Amount must be positive.", nameof(amount));

            Amount += amount;
        }

        public void Decrease(float amount)
        {
            if (!CanBeChanged)
                throw new InvalidOperationException("Balance is frozen and cannot be changed.");

            if (amount < 0)
                throw new ArgumentException("Amount must be positive.", nameof(amount));

            if (Amount < amount)
                throw new InvalidOperationException("Insufficient balance.");

            Amount -= amount;
        }

        public void Freeze(bool state)
        {
            CanBeChanged = !state;
        }
    }
}
