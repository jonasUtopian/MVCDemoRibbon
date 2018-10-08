using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Model.View
{
    public class BaseModel: INotifyPropertyChanged
    {
        protected void OnPropertyChanged(string propertyName)
        {
            SyncContext.Post(new SendOrPostCallback(NotifyPropertyChanged), propertyName);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(object state)
        {
            string propertyName = state.ToString();
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public SynchronizationContext SyncContext
        {
            get { return m_syncContext; }
            set { m_syncContext = value; }
        }

        private SynchronizationContext m_syncContext;
    }
}
