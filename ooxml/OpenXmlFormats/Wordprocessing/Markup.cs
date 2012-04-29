﻿using System;
using System.Collections.Generic;
using System.Text;
using NPOI.OpenXmlFormats.Shared;

namespace NPOI.OpenXmlFormats.Wordprocessing
{

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_Bookmark))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_MoveBookmark))]

    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_BookmarkRange : CT_MarkupRange
    {

        private string colFirstField;

        private string colLastField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string colFirst
        {
            get
            {
                return this.colFirstField;
            }
            set
            {
                this.colFirstField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string colLast
        {
            get
            {
                return this.colLastField;
            }
            set
            {
                this.colLastField = value;
            }
        }
    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_MoveBookmark))]

    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_Bookmark : CT_BookmarkRange
    {

        private string nameField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_MoveBookmark : CT_Bookmark
    {

        private string authorField;

        private System.DateTime dateField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public System.DateTime date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute("comments", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = false)]
    public class CT_Comments
    {

        private List<CT_Comment> commentField;

        public CT_Comments()
        {
            this.commentField = new List<CT_Comment>();
        }

        [System.Xml.Serialization.XmlElementAttribute("comment", Order = 0)]
        public List<CT_Comment> comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_Comment : CT_TrackChange
    {

        private List<object> itemsField;

        private List<ItemsChoiceType1> itemsElementNameField;

        private string initialsField;

        public CT_Comment()
        {
            this.itemsElementNameField = new List<ItemsChoiceType1>();
            this.itemsField = new List<object>();
        }

        [System.Xml.Serialization.XmlElementAttribute("oMath", typeof(CT_OMath), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("oMathPara", typeof(CT_OMathPara), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("altChunk", typeof(CT_AltChunk), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("bookmarkEnd", typeof(CT_MarkupRange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("bookmarkStart", typeof(CT_Bookmark), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("commentRangeEnd", typeof(CT_MarkupRange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("commentRangeStart", typeof(CT_MarkupRange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXml", typeof(CT_CustomXmlBlock), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlDelRangeEnd", typeof(CT_Markup), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlDelRangeStart", typeof(CT_TrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlInsRangeEnd", typeof(CT_Markup), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlInsRangeStart", typeof(CT_TrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlMoveFromRangeEnd", typeof(CT_Markup), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlMoveFromRangeStart", typeof(CT_TrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlMoveToRangeEnd", typeof(CT_Markup), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlMoveToRangeStart", typeof(CT_TrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("del", typeof(CT_RunTrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ins", typeof(CT_RunTrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("moveFrom", typeof(CT_RunTrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("moveFromRangeEnd", typeof(CT_MarkupRange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("moveFromRangeStart", typeof(CT_MoveBookmark), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("moveTo", typeof(CT_RunTrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("moveToRangeEnd", typeof(CT_MarkupRange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("moveToRangeStart", typeof(CT_MoveBookmark), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("p", typeof(CT_P), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("permEnd", typeof(CT_Perm), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("permStart", typeof(CT_PermStart), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("proofErr", typeof(CT_ProofErr), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("sdt", typeof(CT_SdtBlock), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("tbl", typeof(CT_Tbl), Order = 0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField.ToArray();
            }
            set
            {
                if (value == null || value.Length == 0)
                    this.itemsField = new List<object>();
                else
                    this.itemsField = new List<object>(value);
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order = 1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField.ToArray();
            }
            set
            {
                if (value == null || value.Length == 0)
                    this.itemsElementNameField = new List<ItemsChoiceType1>();
                else
                    this.itemsElementNameField = new List<ItemsChoiceType1>(value);
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string initials
        {
            get
            {
                return this.initialsField;
            }
            set
            {
                this.initialsField = value;
            }
        }

        public IList<CT_P> GetPList()
        {
            return GetObjectList<CT_P>(ItemsChoiceType1.p);
        }
        #region Generic methods for object operation

        private List<T> GetObjectList<T>(ItemsChoiceType1 type) where T : class
        {
            lock (this)
            {
                List<T> list = new List<T>();
                for (int i = 0; i < itemsElementNameField.Count; i++)
                {
                    if (itemsElementNameField[i] == type)
                        list.Add(itemsField[i] as T);
                }
                return list;
            }
        }
        private int SizeOfArray(ItemsChoiceType1 type)
        {
            lock (this)
            {
                int size = 0;
                for (int i = 0; i < itemsElementNameField.Count; i++)
                {
                    if (itemsElementNameField[i] == type)
                        size++;
                }
                return size;
            }
        }
        private T GetObjectArray<T>(int p, ItemsChoiceType1 type) where T : class
        {
            lock (this)
            {
                int pos = GetObjectIndex(type, p);
                if (pos < 0 || pos >= this.itemsField.Count)
                    return null;
                return itemsField[pos] as T;
            }
        }
        private T InsertNewObject<T>(ItemsChoiceType1 type, int p) where T : class, new()
        {
            T t = new T();
            lock (this)
            {
                int pos = GetObjectIndex(type, p);
                this.itemsElementNameField.Insert(pos, type);
                this.itemsField.Insert(pos, t);
            }
            return t;
        }
        private T AddNewObject<T>(ItemsChoiceType1 type) where T : class, new()
        {
            T t = new T();
            lock (this)
            {
                this.itemsElementNameField.Add(type);
                this.itemsField.Add(t);
            }
            return t;
        }
        private void SetObject<T>(ItemsChoiceType1 type, int p, T obj) where T : class
        {
            lock (this)
            {
                int pos = GetObjectIndex(type, p);
                if (pos < 0 || pos >= this.itemsField.Count)
                    return;
                if (this.itemsField[pos] is T)
                    this.itemsField[pos] = obj;
                else
                    throw new Exception(string.Format(@"object types are difference, itemsField[{0}] is {1}, and parameter obj is {2}",
                        pos, this.itemsField[pos].GetType().Name, typeof(T).Name));
            }
        }
        private int GetObjectIndex(ItemsChoiceType1 type, int p)
        {
            int index = -1;
            int pos = 0;
            for (int i = 0; i < itemsElementNameField.Count; i++)
            {
                if (itemsElementNameField[i] == type)
                {
                    if (pos == p)
                    {
                        index = i;
                        break;
                    }
                    else
                        pos++;
                }
            }
            return index;
        }
        private void RemoveObject(ItemsChoiceType1 type, int p)
        {
            lock (this)
            {
                int pos = GetObjectIndex(type, p);
                if (pos < 0 || pos >= this.itemsField.Count)
                    return;
                itemsElementNameField.RemoveAt(pos);
                itemsField.RemoveAt(pos);
            }
        }
        #endregion
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
        oMath,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
        oMathPara,

        /// <remarks/>
        altChunk,

        /// <remarks/>
        bookmarkEnd,

        /// <remarks/>
        bookmarkStart,

        /// <remarks/>
        commentRangeEnd,

        /// <remarks/>
        commentRangeStart,

        /// <remarks/>
        customXml,

        /// <remarks/>
        customXmlDelRangeEnd,

        /// <remarks/>
        customXmlDelRangeStart,

        /// <remarks/>
        customXmlInsRangeEnd,

        /// <remarks/>
        customXmlInsRangeStart,

        /// <remarks/>
        customXmlMoveFromRangeEnd,

        /// <remarks/>
        customXmlMoveFromRangeStart,

        /// <remarks/>
        customXmlMoveToRangeEnd,

        /// <remarks/>
        customXmlMoveToRangeStart,

        /// <remarks/>
        del,

        /// <remarks/>
        ins,

        /// <remarks/>
        moveFrom,

        /// <remarks/>
        moveFromRangeEnd,

        /// <remarks/>
        moveFromRangeStart,

        /// <remarks/>
        moveTo,

        /// <remarks/>
        moveToRangeEnd,

        /// <remarks/>
        moveToRangeStart,

        /// <remarks/>
        p,

        /// <remarks/>
        permEnd,

        /// <remarks/>
        permStart,

        /// <remarks/>
        proofErr,

        /// <remarks/>
        sdt,

        /// <remarks/>
        tbl,
    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_RunTrackChange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_RPrChange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_ParaRPrChange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_PPrChange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_SectPrChange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_TblPrChange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_TrPrChange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_TcPrChange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_TblPrExChange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_TrackChangeNumbering))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_Comment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_TrackChangeRange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_CellMergeTrackChange))]

    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_TrackChange : CT_Markup
    {

        private string authorField;

        private System.DateTime dateField;

        private bool dateFieldSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public System.DateTime date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateSpecified
        {
            get
            {
                return this.dateFieldSpecified;
            }
            set
            {
                this.dateFieldSpecified = value;
            }
        }
    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_TblGridChange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_MarkupRange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_BookmarkRange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_Bookmark))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_MoveBookmark))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_TrackChange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_RunTrackChange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_RPrChange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_ParaRPrChange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_PPrChange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_SectPrChange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_TblPrChange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_TrPrChange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_TcPrChange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_TblPrExChange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_TrackChangeNumbering))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_Comment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_TrackChangeRange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_CellMergeTrackChange))]

    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_Markup
    {

        private string idField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }




    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_BookmarkRange))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_Bookmark))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_MoveBookmark))]

    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_MarkupRange : CT_Markup
    {

        private ST_DisplacedByCustomXml displacedByCustomXmlField;

        private bool displacedByCustomXmlFieldSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_DisplacedByCustomXml displacedByCustomXml
        {
            get
            {
                return this.displacedByCustomXmlField;
            }
            set
            {
                this.displacedByCustomXmlField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool displacedByCustomXmlSpecified
        {
            get
            {
                return this.displacedByCustomXmlFieldSpecified;
            }
            set
            {
                this.displacedByCustomXmlFieldSpecified = value;
            }
        }
    }
}
