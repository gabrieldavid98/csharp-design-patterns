﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public interface IGUIFactory
    {
        Button CreateButton();
        Checkbox CreateCheckbox();
    }
}
