using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Mechanical.Exhibition.Show.RNMechanicalExhibitionShow
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNMechanicalExhibitionShowModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNMechanicalExhibitionShowModule"/>.
        /// </summary>
        internal RNMechanicalExhibitionShowModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNMechanicalExhibitionShow";
            }
        }
    }
}
