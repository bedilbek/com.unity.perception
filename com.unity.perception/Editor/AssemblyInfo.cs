using System.Runtime.CompilerServices;

#if UNITY_EDITOR
[assembly: InternalsVisibleTo("Unity.Perception.Editor")]
#endif
[assembly: InternalsVisibleTo("Unity.Perception.Editor.Tests")]
[assembly: InternalsVisibleTo("Unity.Perception.Runtime.Tests")]
