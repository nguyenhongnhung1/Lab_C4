using UnityEngine;
using UnityEngine.Video; // Bắt buộc phải có để dùng VideoPlayer
using UnityEngine.SceneManagement; // Dùng nếu bạn muốn chuyển cảnh

public class VideoEventHandler : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject uiToDisplay; // Kéo Panel hoặc Text thông báo vào đây

    void Start()
    {
        // Đăng ký sự kiện
        videoPlayer.prepareCompleted += OnVideoPrepared;
        videoPlayer.loopPointReached += OnVideoFinished;
        
        // Chuẩn bị video (Prepare)
        videoPlayer.Prepare();
    }

    // Được gọi khi video đã sẵn sàng để phát
    void OnVideoPrepared(VideoPlayer source)
    {
        Debug.Log("Video đã chuẩn bị xong và sẵn sàng phát!");
    }

    // Được gọi khi video chạy hết (Lab 7 yêu cầu)
    void OnVideoFinished(VideoPlayer source)
    {
        Debug.Log("Video đã kết thúc!");
        
        // Cách 1: Hiển thị UI thông báo
        if (uiToDisplay != null) uiToDisplay.SetActive(true);

        // Cách 2: Chuyển sang Scene mới (Dùng cho Mini Project)
        // SceneManager.LoadScene("GameplayScene");
    }
}
