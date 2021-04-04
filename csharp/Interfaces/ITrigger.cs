﻿using GitHubBot;
using System.Collections.Generic;

namespace Interfaces
{
    interface ITrigger<TContext>
    {
        public bool Condition(TContext obj);

        public void Action(TContext obj);
    }
}
