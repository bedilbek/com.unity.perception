﻿using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.Experimental.Perception.Randomization.Parameters;
using UnityEngine.UIElements;

namespace UnityEngine.Perception.Randomization.Editor
{
    class ColorHsvaField : ColorField
    {
        SerializedProperty m_Property;
        SerializedProperty m_H;
        SerializedProperty m_S;
        SerializedProperty m_V;
        SerializedProperty m_A;

        public ColorHsvaField(SerializedProperty property)
        {
            m_Property = property;
            label = m_Property.displayName;

            m_H = m_Property.FindPropertyRelative("h");
            m_S = m_Property.FindPropertyRelative("s");
            m_V = m_Property.FindPropertyRelative("v");
            m_A = m_Property.FindPropertyRelative("a");

            rawValue = (Color)new ColorHsva(m_H.floatValue, m_S.floatValue, m_V.floatValue, m_A.floatValue);

            this.RegisterValueChangedCallback(evt =>
            {
                var color = (ColorHsva)evt.newValue;
                m_H.floatValue = color.h;
                m_S.floatValue = color.s;
                m_V.floatValue = color.v;
                m_A.floatValue = color.a;
                m_Property.serializedObject.ApplyModifiedProperties();
            });
        }
    }
}
