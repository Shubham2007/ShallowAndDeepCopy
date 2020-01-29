using System;
using System.Collections.Generic;
using System.Text;

namespace DeepCopyObjects.DeepCloning
{
    public class CloningStrategy
    {
        private ICloningStrategy _strategy = null;

        public CloningStrategy(ICloningStrategy strategy)
        {
            _strategy = strategy;
        }       

        public void SetStrategy(ICloningStrategy strategy)
        {
            _strategy = strategy;
        }

        public TObject Clone<TObject>(TObject originalObject)
        {
            return _strategy.Clone<TObject>(originalObject);
        } 
    }
}
