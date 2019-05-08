using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Demos.RPGEditor;
using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities;
using Sirenix.Utilities.Editor;
using UnityEngine;

public class OdinWindowTest : OdinMenuEditorWindow
{
   
    
    public  static void Open()
    {
        var window = GetWindow<OdinWindowTest>();
        window.position = GUIHelper.GetEditorWindowRect().AlignCenter(800, 500);
    }
    
    [VerticalGroup("Split/Meta")]
    public string Name;

    [VerticalGroup("Split/Meta")]
    public string Surname;
    
    List<OdinCharacterWrapper>lst=new List<OdinCharacterWrapper>(10);

    protected override OdinMenuTree BuildMenuTree()
    {
        var tree = new OdinMenuTree(true);
        tree.DefaultMenuStyle.IconSize = 28.00f;
        tree.Config.DrawSearchToolbar = true;
       // CharacterOverview.Instance.UpdateCharacterOverview();
        lst.Add(new OdinCharacterWrapper(){Name = "32"});
        //左边框名称+右边的布局
        tree.Add("左边", lst);
        
        tree.EnumerateTree().AddIcons<Character>(x => x.Icon);
        tree.EnumerateTree().AddIcons<Item>(x => x.Icon);
        return tree;
    }

  
}
