﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Equinox.Video
{
    /// <summary>
    /// Generalized screen that can handle updates and draw itself.
    /// </summary>
    class Screen : DrawableGameComponent
    {
        protected Game game;
        protected ScreenManager screenManager;

        /// <summary>
        /// Initialize a screen.
        /// </summary>
        /// <param name="manager"></param>
        public Screen(ScreenManager manager) : base(manager.game)
        {
            game = manager.game;
            screenManager = manager;
        }
    }
}
