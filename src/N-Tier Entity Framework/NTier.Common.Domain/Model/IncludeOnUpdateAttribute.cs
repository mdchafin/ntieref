﻿// Copyright (c) Trivadis. All rights reserved. See license.txt in the project root for license information.

using System;

namespace NTier.Common.Domain.Model
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public sealed class IncludeOnUpdateAttribute : Attribute
    {
    }
}
