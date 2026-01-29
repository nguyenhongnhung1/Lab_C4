I. Chi tiết kết quả thực hiện các Lab
Lab 1 – AudioSource Cơ Bản (Sound Trigger)
Thực hiện: Tạo đối tượng AudioObject, gắn thành phần Audio Source và file nhạc Die With A Smile.

Cấu hình: Tắt Play On Awake. Sử dụng Script nhận lệnh từ phím Space để Play() và phím S để Stop().

Kết quả: Âm thanh phát và dừng chính xác theo phím bấm.

Lab 2 – Audio 2D vs 3D (Spatial Audio)
Thực hiện: Tạo hai đối tượng Sound2D và Sound3D.

Cấu hình: * Sound2D: Kéo Spatial Blend về 0.

Sound3D: Kéo Spatial Blend về 1.

Nhận xét: * Dùng 2D khi: Nhạc nền (BGM), UI Sound (âm thanh giao diện).

Dùng 3D khi: Tiếng súng, bước chân, vật thể phát tiếng động trong môi trường để tạo cảm giác không gian.

Lab 3 – Điều Khiển Âm Thanh Toàn Cục (AudioListener)
Thực hiện: Gán Audio Listener vào Main Camera.

Cấu hình: Sử dụng phím M để đổi trạng thái AudioListener.pause (Mute toàn cục).

Kết quả: Toàn bộ âm thanh trong Scene im lặng khi nhấn M mà không cần dừng từng nguồn phát đơn lẻ.

Lab 4 – AudioClip Import & Optimization
Báo cáo lựa chọn cấu hình:

BGM (Nhạc nền): Chọn Load Type: Streaming và Compression: Vorbis để tiết kiệm RAM vì file nhạc thường dài.

SFX (Hiệu ứng ngắn): Chọn Load Type: Decompress On Load để đạt hiệu suất phản hồi nhanh nhất khi chơi.

Lab 5 – VideoPlayer Cơ Bản
Thực hiện: Import video gunshot-352466.mp4.

Khắc phục lỗi: Thực hiện Transcode sang chuẩn H.264 trong Inspector để sửa lỗi "Error while reading movie".

Kết quả: Nhấn phím V để bắt đầu phát VideoPlayer.

Lab 6 – Video Render Target
Thực hiện: Tạo Render Texture tại menu Create > Rendering > Render Texture.

Cấu hình: Gán Render Texture vào ô Target Texture của VideoPlayer và hiển thị lên UI thông qua Raw Image.

Kết quả: Video hiển thị đúng khung hình trên giao diện người dùng thay vì đè lên toàn bộ Camera.

Lab 7 – Video Events & Control
Thực hiện: Viết Script VideoEventHandler để lắng nghe sự kiện loopPointReached.

Kết quả: Khi video kết thúc, đối tượng Text (TMP) được kích hoạt (SetActive(true)) để thông báo cho người chơi.

II. Mini Project – Intro Cutscene Game
Cấu trúc: Sử dụng kết hợp VideoPlayer và AudioSource.

Tính năng: 1. Video intro tự động chạy và có âm thanh hệ thống (đã bật System Audio trong Snipping Tool). 2. Sử dụng sự kiện kết thúc video để tự động chuyển sang Scene Gameplay chính. 3. Thiết kế nút Skip gắn sự kiện dừng Video và gọi hàm chuyển Scene ngay lập tức.

III. Nhận xét chung
Hệ thống Audio và Video của Unity 6 hoạt động ổn định nhưng yêu cầu chuẩn hóa định dạng (Transcode) đối với các file media bên ngoài.

Việc sử dụng Render Texture (Lab 6) là phương pháp tối ưu nhất để tích hợp video vào giao diện Game một cách chuyên nghiệp.

Khi thực hiện ghi hình minh chứng, cần lưu ý cấu hình thiết bị ghi (như Snipping Tool) để thu được cả System Audio, đảm bảo tính xác thực của bài Lab.
