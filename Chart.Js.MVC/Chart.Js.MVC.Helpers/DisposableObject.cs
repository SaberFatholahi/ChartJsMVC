using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Chart.Js.MVC.Helpers
{

    public abstract class DisposableObject : IDisposable
    {
        private bool _isDisposed;

        public virtual bool IsDisposed
        {
            [DebuggerStepThrough]
            get { return _isDisposed; }
        }

        [DebuggerStepThrough]
        protected void CheckDisposed()
        {
            if (_isDisposed)
            {
                throw new ObjectDisposedException(GetType().FullName);
            }
        }

        [DebuggerStepThrough]
        protected void CheckDisposed(string errorMessage)
        {
            if (_isDisposed)
            {
                throw new ObjectDisposedException(GetType().FullName, string.Format(CultureInfo.CurrentCulture, errorMessage));
            }
        }

        [DebuggerStepThrough]
        public void Dispose()
        {
			if (!_isDisposed)
			{
				Dispose(true);
				GC.SuppressFinalize(this);
			}
        }

        protected void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                OnDispose(disposing);
            }
            _isDisposed = true;
        }

        protected abstract void OnDispose(bool disposing);

        protected static void DisposeEnumerable(IEnumerable enumerable)
        {
            if (enumerable != null)
            {
                foreach (object obj2 in enumerable)
                {
                    DisposeMember(obj2);
                }
                DisposeMember(enumerable);
            }
        }

        protected static void DisposeDictionary<TK, TV>(IDictionary<TK, TV> dictionary)
        {
            if (dictionary != null)
            {
                foreach (KeyValuePair<TK, TV> pair in dictionary)
                {
                    DisposeMember(pair.Value);
                }
                DisposeMember(dictionary);
            }
        }

        protected static void DisposeDictionary(IDictionary dictionary)
        {
            if (dictionary != null)
            {
                foreach (IDictionaryEnumerator pair in dictionary)
                {
                    DisposeMember(pair.Value);
                }
                DisposeMember(dictionary);
            }
        }

        protected static void DisposeMember(object member)
        {
            IDisposable disposable = member as IDisposable;
	        disposable?.Dispose();
        }

        ~DisposableObject()
        {
            Dispose(false);
        }

    }

}
