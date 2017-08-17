using UnityEditor;
using UnityEngine;

namespace IronFury
{
	public class AssetBundleWindow : EditorWindow
	{
		[MenuItem("Tools/Publish AssetBundle")]
		static void ShowWindow()
		{
			GetWindow<AssetBundleWindow>().Show();
		}

		Vector2 scrollPosition;

		void OnGUI()
		{
			EditorGUILayout.BeginScrollView(scrollPosition, GUILayout.MinWidth(300), GUILayout.Height(300));
			string sss = "ddd";
			EditorGUILayout.LabelField(sss);
			EditorGUILayout.LabelField(sss);
			EditorGUILayout.LabelField(sss);
			EditorGUILayout.EndScrollView();
			GUILayout.Label("scene id build");
		}
    }
}