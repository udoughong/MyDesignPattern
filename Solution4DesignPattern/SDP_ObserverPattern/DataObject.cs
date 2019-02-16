using System;
using System.Collections.Generic;

namespace SDP_ObserverPattern
{
    public class DataObject
    {
        String data;
        List<View> views = new List<View>();

        public void AddView(View v)
        {
            views.Add(v);
        }

        public void SetData(String d)
        {
            data = d;
            Notify();
        }

        public void LoadData()
        {
            //Data is loaded from a file
            data = "Data is loaded from a file";
            Notify();
        }
        //Helper method to notify view
        private void Notify()
        {
            foreach (View v in views)
            {
                v.Update(data);
            }
        }
    }
}