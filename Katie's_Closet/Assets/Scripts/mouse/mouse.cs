using UnityEngine;

public class mouse : MonoBehaviour
{
    public Texture2D cursorText;
    void Start()
    {
        Texture2D resizedCursor = ResizeTexture(cursorText, 64, 64);
        Cursor.SetCursor(resizedCursor, Vector3.zero, CursorMode.ForceSoftware);
    }
    
    Texture2D ResizeTexture(Texture2D source, int newWidth, int newHeight)
    {
        RenderTexture rt = RenderTexture.GetTemporary(newWidth, newHeight);
        RenderTexture.active = rt;

        Graphics.Blit(source, rt);
        Texture2D result = new Texture2D(newWidth, newHeight);
        result.ReadPixels(new Rect(0, 0, newWidth, newHeight), 0, 0);
        result.Apply();

        RenderTexture.active = null;
        RenderTexture.ReleaseTemporary(rt);

        return result;
    }
}
