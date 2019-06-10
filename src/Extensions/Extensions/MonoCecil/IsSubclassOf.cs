﻿using System.Linq;
using Mono.Cecil;

namespace Xpand.Source.Extensions.MonoCecil{
    internal static partial class MonoCecilExtensions{

        public static bool IsSubclassOf(this TypeDefinition childTypeDef, TypeDefinition parentTypeDef){
            return childTypeDef.MetadataToken
                   != parentTypeDef.MetadataToken
                   && childTypeDef
                       .BaseClasses()
                       .Any(b => b.MetadataToken == parentTypeDef.MetadataToken);
        }


    }
}