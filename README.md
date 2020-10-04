# **Vocabulary Up**

## **Mục tiêu:** 
- Hỗ trợ học từ vựng tiếng Anh cho mọi người.  
## **Đối tượng:** 
- Những người có nhu cầu học và nâng cao vốn từ vựng tiếng Anh.  
## **Quy mô:** 
- Trước mắt sẽ hướng đến người dùng là các sinh viên trường Đại học Công Nghệ Thông Tin.    
## **Yêu cầu:**
-   Giao diện thân thiện với người dùng.
-   Các thao tác dễ dàng.
-   Cơ chế hỗ trợ cho việc học phải hiệu quả.
## **Mô tả:** 
- ### **Hình thức:** 
    - Flashcards.  
    > Người dùng sẽ học từ vựng tiếng Anh thông qua các Flashcard lần lượt hiện lên trên màn hình.
- ### **Chi tiết ý tưởng:**   
    - Khi mở ứng dụng, sẽ cho user đăng nhập.  
    - Sau khi đăng nhập sẽ hiện 1 flashcard, nó sẽ chứa thông tin sơ bộ là từ vựng và hình ảnh. Các flashcard khác sẽ hiện lên từng lượt một sau mỗi lần nhấn bên trái hoặc bên phải flashcard trước đó.  
    - Nhấn bên phải flashcard để chỉ đã nhớ, nhấn bên trái để chỉ chưa nhớ, ấn vào flashcard đó để hiển thị mục “Thông tin chi tiết” chứa thông tin cụ thể về từ vựng (nghĩa, từ vựng liên quan, cách phát âm,...).  
    - Những từ ở mục “chưa nhớ” sẽ được hiển thị lại một lần nữa sau một số lượng lần xuất hiện nhất định các flashcard khác hoặc ở phiên sử dụng tiếp theo.
    - Những từ ở mục “đã nhớ” sẽ được cho vào phần Revise (Ôn tập) và người dùng có thể vào phần đó để ôn lại những từ đã học được.  
- ### **Các tính năng:**  
    - User access.  
    - Hiển thị flashcard (Display Flashcards).
    - Ôn tập (Revise).
    - Phân loại từ vựng theo chủ đề (Categorize Words).
    - Thống kê và đánh giá (Statistics & Evaluation). 
    - Tùy chỉnh giao diện (Customization).  
## **Chi tiết tính năng:**
- ### **User access**
    - Trước khi vào giao diện chính của ứng dụng, sẽ hiển thị một giao diện để login.
    - Trong giao diện login, sẽ có một phần để nhập username và password.
    - Nếu không có tài khoản truy cập, người dùng có thể đăng ký bằng nút Sign up có trong giao diện login để đăng ký một tài khoản truy cập.
    - Người dùng cũng có thể truy cập mà không cần đăng nhập với nút Login as guest.
    - Sử dụng ứng dụng với một tài khoản riêng sẽ giúp lưu lại tiến trình học cũng như thống kê, đánh giá và những tùy chỉnh riêng do người dùng đã thiết lập.
- ### **Display flashcards**
    - Sau khi đăng nhập sẽ hiện 1 flashcard, nó sẽ chứa thông tin sơ bộ là từ vựng và hình ảnh. Các flashcard khác sẽ hiện lên từng lượt một sau mỗi lần nhấn bên trái hoặc bên phải flashcard trước đó.
    - Nhấn bên phải flashcard để chỉ đã nhớ, nhấn bên trái để chỉ chưa nhớ, ấn vào flashcard đó để hiển thị mục “Thông tin chi tiết” chứa thông tin cụ thể về từ vựng (nghĩa, từ vựng liên quan, cách phát âm,...).
    - Những từ ở mục “chưa nhớ” sẽ được hiển thị lại một lần nữa sau một số lượng lần xuất hiện nhất định các flashcard khác hoặc ở phiên sử dụng tiếp theo.
    - Những từ ở mục “đã nhớ” sẽ được cho vào phần Revise (Ôn tập) và người dùng có thể vào phần đó để ôn lại những từ đã học được.
- ### **Revise**
    - Tương tự như Display flashcards, chỉ khác là khi vào phần Revise, những từ vựng hiện lên là những từ đã được cho vào mục “đã nhớ” ở những lần sử dụng Display flashcards trước đó.
    - Nhấn bên trái sẽ xóa từ vựng đó ra khỏi phần Revise, còn nhấn bên phải sẽ tiếp tục giữ từ vựng đó ở phần Revise, ghi nhận là đã nhớ.
- ### **Categorize words**
    - Trong phần chọn chủ đề, sẽ hiển thị các chủ đề để người dùng chọn.
    - Mặc định ban đầu sẽ là chọn toàn bộ các chủ đề.
    - Khi chọn, người dùng có thể chọn nhiều chủ đề và ít nhất là phải có 1 chủ đề được chọn.
- ### **Statistics & Evaluation**
    - Chương trình đánh giá theo số lượng từ người dùng đã học.
    - Lưu trữ lại thành tích học cao nhất theo tuần (hoặc ngày) và thành tích học của tuần (hoặc ngày) hiện tại.
    - Nếu vượt qua thành tích học cao nhất trước đó, sẽ có thông báo chúc mừng.
- ### **Customization**
    - Cho phép người dùng tùy chỉnh thiết kế giao diện (theme, background, flashcard shape, âm thanh, …).
## **Demo các giao diện**
> Bao gồm 3 phần chính là Main, Revise, Statistics.
- ### **Main**
    ![MainUI](https://drive.google.com/uc?export=view&id=18kwenadsTLDrlWcKQtZtTVjf7ENXbw-A)
- ### **Revise**
    ![ReviseUI](https://drive.google.com/uc?export=view&id=1jATwlSfwSHgJNPnBzTBUVn35p12gQeNb)
- ### **Statistics**
    ![StatisticsUI](https://drive.google.com/uc?export=view&id=1bLPyVl5i_NZgJyrX8GTJa33NjHFHolIq)
## **Tác giả:**   
- Trương Kim Lâm - 19521743.    
- Trần Lê Thanh Tùng - 19522496.  
- Lương Thiện Phước - 19522055.
