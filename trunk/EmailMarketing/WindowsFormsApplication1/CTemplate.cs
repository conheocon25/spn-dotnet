﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailMarketing
{
    public class CTemplate
    {
        private int _Id;
        private string _Name;
        private string _Content;

        public CTemplate(int Id = 0, string Name = "", string Content = "")
        {
            this._Id = Id;
            this._Name = Name;
            this._Content = Content;
        }

        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this._Id = Id;
            }
        }

        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = Name;
            }
        }

        public string Content
        {
            get
            {
                return this._Content;
            }
            set
            {
                this._Content = Content;
            }
        }

    }

    public class CollectionTemplate
    {
        private List<CTemplate> lstTemplate;

        public CollectionTemplate()
        {
            this.lstTemplate = new List<CTemplate>();

            this.lstTemplate.Add(new CTemplate(1, "Mẫu 1", "Nội dung mẫu thư thứ 1"));
            this.lstTemplate.Add(new CTemplate(2, "Mẫu 2", "Nội dung mẫu thư thứ 2"));
            
        }

        public List<CTemplate> getAll()
        {
            return this.lstTemplate;
        }

    }
}
