/*
 * Copyright 2012 - Adam Haile
 * http://adamhaile.net
 *
 * This file is part of Elpis.
 * Elpis is free software: you can redistribute it and/or modify 
 * it under the terms of the GNU General Public License as published by 
 * the Free Software Foundation, either version 3 of the License, or 
 * (at your option) any later version.
 * 
 * Elpis is distributed in the hope that it will be useful, 
 * but WITHOUT ANY WARRANTY; without even the implied warranty of 
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the 
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License 
 * along with Elpis. If not, see http://www.gnu.org/licenses/.
*/

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using MaterialDesignThemes.Wpf;

namespace Elpis.Controls
{
    public class SVGImageButton : Button
    {
        public static readonly DependencyProperty KindProperty =
            DependencyProperty.RegisterAttached("Kind", typeof(PackIconKind), typeof(SVGImageButton),
                                                new PropertyMetadata(null));

        public SVGImageButton()
            : base()
        {
            //Do not want any of these buttons to respond to Space select, do this for all
            this.PreviewKeyDown += ((o, e) => e.Handled = true);
        }

        public PackIconKind Kind
        {
            get { return (PackIconKind)GetValue(KindProperty); }
            set { SetValue(KindProperty, value); }
        }
    }
}