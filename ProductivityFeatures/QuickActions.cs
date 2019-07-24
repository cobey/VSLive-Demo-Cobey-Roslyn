using System;
namespace ProductivityFeatures
{
    class QuickActions
    {
        // Split if statements into nested if statements
        // Place cursor by the '&&' and type (Ctrl + .)
        // Select 'Split into nested if statements'
        public void SplitIf()
        {
            if (1 < 2 && 2 > 3)
            {

            }
        }

        // Merge nested if statements
        // Place cursor in 'if' keyword
        // Type (Ctrl +.) and select 'Merge with nested if statement'
        public void MergeIf()
        {
            if (1 < 2)
            {
                if (2 > 3)
                {

                }
            }
        }


    }
}
