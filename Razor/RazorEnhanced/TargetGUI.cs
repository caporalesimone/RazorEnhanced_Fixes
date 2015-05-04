﻿using System;
using System.IO;
using System.Collections.Generic;
using Assistant;
using System.Windows.Forms;
using System.Threading;
using RazorEnhanced;

namespace RazorEnhanced
{
	public class TargetGUI
	{
        [Serializable]
        public class TargetGUIObject
        {
            private string m_Selector;
            public string Selector { get { return m_Selector; } }

            private Mobiles.Filter m_Filter;
            public Mobiles.Filter Filter { get { return m_Filter; } }

            public TargetGUIObject(string selector, Mobiles.Filter filter)
            {
                m_Selector = selector;
                m_Filter = filter;
            }
        }

        public class TargetGUIObjectList
        {
            private string m_Name;
            public string Name { get { return m_Name; } }

            private TargetGUIObject m_TargetObject;
            public TargetGUIObject TargetObject { get { return m_TargetObject; } }

            public TargetGUIObjectList(string name, TargetGUIObject targetobject)
            {
                m_Name = name;
                m_TargetObject = targetobject;
            }
        }

        internal static void RefreshTarget()
        {
            Assistant.Engine.MainWindow.TargetListView.Items.Clear();
            List<TargetGUI.TargetGUIObjectList> list = Settings.Target.ReadAll();
            foreach (TargetGUIObjectList target in list)
            {
                ListViewItem listitem = new ListViewItem();

                // Target ID
                listitem.SubItems.Add(target.Name);

                // Body List
                if (target.TargetObject.Filter.Bodies.Count > 0 )
                {
                    string bodylist = "";
                    foreach (int body in target.TargetObject.Filter.Bodies)
                    {
                        bodylist = bodylist + body.ToString() + " - ";
                    }
                    listitem.SubItems.Add(bodylist);
                }
                else
                {
                    listitem.SubItems.Add("*");
                }

                // Target Name
                if (target.TargetObject.Filter.Name !="")
                    listitem.SubItems.Add(target.TargetObject.Filter.Name);
                else
                    listitem.SubItems.Add("*");

                // Hue List
                if (target.TargetObject.Filter.Hues.Count > 0)
                {
                    string huelist = "";
                    foreach (int hue in target.TargetObject.Filter.Hues)
                    {
                        huelist = huelist + hue.ToString() + " - ";
                    }
                    listitem.SubItems.Add(huelist);
                }
                else
                {
                    listitem.SubItems.Add("*");
                }

                // Min Range
                if (target.TargetObject.Filter.RangeMin != -1)
                    listitem.SubItems.Add(target.TargetObject.Filter.RangeMin.ToString());
                else
                    listitem.SubItems.Add("*");

                // Max Range
                if (target.TargetObject.Filter.RangeMax != -1)
                    listitem.SubItems.Add(target.TargetObject.Filter.RangeMax.ToString());
                else
                    listitem.SubItems.Add("*");

                // Poisoned
                if (target.TargetObject.Filter.Poisoned)
                    listitem.SubItems.Add("X");
                else
                    listitem.SubItems.Add("O");

                // Blessed
                if (target.TargetObject.Filter.Blessed)
                    listitem.SubItems.Add("X");
                else
                    listitem.SubItems.Add("O");

                // Human
                if (target.TargetObject.Filter.IsHuman)
                    listitem.SubItems.Add("X");
                else
                    listitem.SubItems.Add("O");

                // Ghost
                if (target.TargetObject.Filter.IsGhost)
                    listitem.SubItems.Add("X");
                else
                    listitem.SubItems.Add("O");

                // Female
                if (target.TargetObject.Filter.Female)
                    listitem.SubItems.Add("F");
                else
                    listitem.SubItems.Add("M");

                // Female
                if (target.TargetObject.Filter.Warmode)
                    listitem.SubItems.Add("X");
                else
                    listitem.SubItems.Add("O");

                // Female
                if (target.TargetObject.Filter.Friend)
                    listitem.SubItems.Add("X");
                else
                    listitem.SubItems.Add("O");

                // NotoColor list
                if (target.TargetObject.Filter.Notorieties.Count > 0)
                {
                    string notolist = "";
                    foreach (int noto in target.TargetObject.Filter.Notorieties)
                    {
                        notolist = notolist + noto.ToString() + " - ";
                    }
                    listitem.SubItems.Add(notolist);
                }
                else
                {
                    listitem.SubItems.Add("*");
                }

                // Selector
                listitem.SubItems.Add(target.TargetObject.Selector);


                Assistant.Engine.MainWindow.TargetListView.Items.Add(listitem);
            }
        }

	}
}
