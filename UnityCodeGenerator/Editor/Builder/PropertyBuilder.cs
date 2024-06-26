﻿using UnityCodeGen.Ast;

namespace UnityCodeGen.Builder
{
    public class PropertyBuilder
    {
        public string Name => _name;

        private string _name;
        private string _type;

        private string _getBody;
        private string _setBody;

        private bool _isStatic;

        private bool _hasSet = true;

        private AccessType _visibility;
        private AccessType _setVisibility;

        public PropertyBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public PropertyBuilder WithType(string type)
        {
            _type = type;
            return this;
        }

        public PropertyBuilder WithVisibility(AccessType visibility)
        {
            _visibility = visibility;
            return this;
        }

        public PropertyBuilder WithSetVisibility(AccessType setVisibility)
        {
            _setVisibility = setVisibility;
            return this;
        }

        public PropertyBuilder IsStatic(bool isStatic)
        {
            _isStatic = isStatic;
            return this;
        }

        public PropertyBuilder WithGetBody(string body)
        {
            _getBody = body;
            return this;
        }

        public PropertyBuilder WithSetBody(string body)
        {
            _setBody = body;
            return this;
        }

        public PropertyBuilder HasSet(bool hasSet)
        {
            _hasSet = hasSet;
            return this;
        }

        public PropertyNode Build()
        {
            return new PropertyNode
            {
                Name = _name,
                Visibility = _visibility,
                SetVisibility = _setVisibility,
                Type = _type,
                IsStatic = _isStatic,
                GetBody = _getBody,
                SetBody = _setBody,
                HasSet = _hasSet
            };
        }
    }
}
