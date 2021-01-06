using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;

namespace TicTakTok.Model
{
    public class _HomeViewModel
    {
        public string InputDescription = "test";
        private ICommand _ConnectionInit;
        public ICommand ConnectionInit
        {
            get
            {
                return this._ConnectionInit;
            }
            set
            {
                this._ConnectionInit = value;
            }
        }
    }
}
