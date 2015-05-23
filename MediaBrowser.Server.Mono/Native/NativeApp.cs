﻿
namespace MediaBrowser.Server.Mono.Native
{
    /// <summary>
    /// Class NativeApp
    /// </summary>
    internal class NativeApp : BaseMonoApp
    {
        /// <summary>
        /// Shutdowns this instance.
        /// </summary>
        public override void Shutdown()
        {
            MainClass.Shutdown();
        }

        /// <summary>
        /// Determines whether this instance [can self restart].
        /// </summary>
        /// <value><c>true</c> if this instance can self restart; otherwise, <c>false</c>.</value>
        public override bool CanSelfRestart
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Restarts this instance.
        /// </summary>
        public override void Restart()
        {
            MainClass.Restart();
        }
    }
}
