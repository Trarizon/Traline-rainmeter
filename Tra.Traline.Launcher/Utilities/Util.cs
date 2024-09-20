using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Tra.Traline.Launcher.Utilities;
internal static class Util
{
	private static bool s_EncodingProviderRigistered = false;

	public static Encoding GetEncoding(int codepages)
	{
		if (!s_EncodingProviderRigistered) {
			Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
			s_EncodingProviderRigistered = true;
		}
		return Encoding.GetEncoding(codepages);
	}

	public static T? HitVisualParent<T>(Visual reference, Point point) where T : DependencyObject
	{
		var hit = VisualTreeHelper.HitTest(reference, point);
		if (hit is null) return null;

		DependencyObject dobj = hit.VisualHit;
		while (dobj is not null) {
			if (dobj is T obj) return obj;
			dobj = VisualTreeHelper.GetParent(dobj);
		}
		return null;
	}

	public static T? GetChildBfs<T>(this DependencyObject reference) where T : DependencyObject
	{
		Queue<DependencyObject> refQueue = new();
		refQueue.Enqueue(reference);

		while (refQueue.Count > 0) {
			var head = refQueue.Dequeue();
			if (head is T res) return res;

			for (int i = 0; i < VisualTreeHelper.GetChildrenCount(head); i++) {
				refQueue.Enqueue(VisualTreeHelper.GetChild(head, i));
			}
		}

		return null;
	}

	public static bool IsControlKeyDown(bool ctrl = false, bool shift = false, bool alt = false)
	{
		if (ctrl && !Keyboard.IsKeyDown(Key.LeftCtrl) && !Keyboard.IsKeyDown(Key.RightCtrl))
			return false;
		if (shift && !Keyboard.IsKeyDown(Key.LeftShift) && !Keyboard.IsKeyDown(Key.RightShift))
			return false;
		if (alt && !Keyboard.IsKeyDown(Key.LeftAlt) && !Keyboard.IsKeyDown(Key.RightAlt))
			return false;
		return true;
	}
}
