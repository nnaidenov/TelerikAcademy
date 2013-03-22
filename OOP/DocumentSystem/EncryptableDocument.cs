using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public abstract class EncryptableDocument : BinaryDocument, IEncryptable
    {
        private bool isEncrypted;

        public bool IsEncrypted
        {
            get { return this.isEncrypted; }
            set { this.isEncrypted = value; }
        }

        public void Encrypt()
        {
            isEncrypted = true;
        }

        public void Decrypt()
        {
            isEncrypted = false;
        }

        public override string ToString()
        {
            if (this.isEncrypted)
            {
                return String.Format("{0}[encrypted]", this.GetType().Name);
            }
            else
            {
                return base.ToString();
            }
        }
    }
