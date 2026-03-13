using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPriciples.Principles.Encapsulation
{
	internal class BankAccount
	{
		 decimal _balance;
		private string _accountNumber;
		
		


		private int _taxes; 
		public int Taxes { 
			get => _taxes - 50;
	
		}
		public decimal Balance
		{
			get => _balance;
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Deposit amount must be positive");
				}
				_balance = value;
			}
		}
		


		 string AccountNumber { get; set; }


		public BankAccount(string AccountNumber, int Balance)
		{
			this.AccountNumber = AccountNumber;
			this.Balance = Balance;
		}

		///
		/// Encapsulation
		/// Build Data (fields => attributes) and methods that 
		/// operate on that data within the same unit (object)
		/// access to internal state (attributes) is controlled via 
		/// Access Modifiers (Public, Private, Protected)
		/// applying open-closed Principle => self-study
		public bool Deposit( decimal amount)
		{
			if(amount <=0)
			{
				Console.WriteLine("Deposit amount must be positive ");
				return false;
			}
			Balance += (amount-5);
			// Balance = Balance + amount-5;
			// saveChanges()
			return true;
		}
	}
}
