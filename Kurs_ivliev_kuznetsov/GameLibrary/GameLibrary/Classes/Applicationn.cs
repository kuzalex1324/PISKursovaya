using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibraryDA.Classes
{
    public class Applicationn
    {
        public DateTime CreatedDate { get; set; }
        public bool IsChecked { get; set; }
        public Administrator Reviewer { get; set; }
        public string Reason { get; set; }

        public Applicationn(DateTime createdDate, bool isChecked, Administrator reviewer, string reason)
        {
            CreatedDate = createdDate;
            IsChecked = isChecked;
            Reviewer = reviewer;
            Reason = reason;
        }

        public override string ToString()
        {
            string result = "";
            if (IsChecked) 
            {
                result += "Проверено";
            }
            else
            {
                result += "Не проверено";
            }
            result += "                       " + CreatedDate.ToString().Substring(0,10)+ "                       " + Reviewer.Name+ "               " + Reason;
            return result;
        }

        public void Approve()
        {
            if (IsChecked)
                throw new InvalidOperationException("Application has already been reviewed.");

            IsChecked = true;
            Reason = "Approved";
        }

        public void Decline(in string reason)
        {
            if (IsChecked)
                throw new InvalidOperationException("Application has already been reviewed.");

            IsChecked = true;
            Reason = reason;
        }

        public void AssignReviewer(Administrator reviewer)
        {
            Reviewer = reviewer ?? throw new ArgumentNullException(nameof(reviewer));
        }
    }
}
