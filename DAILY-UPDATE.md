# Daily Update
✅🔄❌📌

## 2025-10-07
- Nay hơi bận bên công ty, với bên start-up nên chưa có tiến triển gì

---

## 2025-10-05
- OK, đã tạo project kết nối DB, tuy nhiên chưa thử test xem đã connect được và query được chưa
- Tiếp theo sẽ mock 1 ít data user, để làm authentication

---

## 2025-10-02
- Hôm nay chọn công nghệ sẽ sử dụng: 
    + 1 năm nay không được động vào sâu và nhiều vào c# .net, nên chắc sẽ chọn ASP .NET Core MVC
    + Oke, nay cứ init dự án MVC cái đã, xong sẽ tính làm gì tiếp theo
    + Cứ làm 1 cái MVP trước, rồi tính đến mấy cái râu ria tối ưu sau
- Oke đã init dự án xong, giờ tính xem mai làm gì tiếp theo:
    + DB Connection: chắc chọn EF core là đẹp
    + Authentication: đăng ký, đăng nhập, đăng nhập với google, facebook đê
📌 Cứ thế đã, khéo làm hết đống kể trên hết cả cuối tuần

---

## 2025-09-30
- Nay có phỏng vấn 2 chỗ, chưa có kết quả nhưng tự mình thấy chắc không pass vì chưa oke lắm
- Kệ đi, dù sao thì, hôm nay mình hơi bận nên sẽ chỉ update phần query SQL để tạo DB thôi, lát nữa nếu có thời gian mình sẽ update thêm 

---

## 2025-09-27
- Có thử tìm hiểu và tham khảo blog sau: https://thanhle.blog/
- Có các điểm như sau:
    + dùng giscus để quản lý phần comment
    + dùng notion api để viết bài viết luôn :v siêu tiện
- Mình cảm thấy blog này thật sự tối ưu và đơn giản, có 1 cái là nếu dùng notion api thì mình nghĩ sẽ bị rate limit, nhưng với 1 personal blog như này thì đó không phải vấn đề
- Mình bắt đầu suy nghĩ lại về cách xây dựng, tuy nhiên về mục đích thì mình muốn showcase 1 chút về tech C# nên vẫn sẽ trung thành với cách ban đầu :V
✅ Phần đầu mục, text in đậm, ảnh, Table of contents của 1 bài post sẽ dùng Markdown kekeke

---

## 2025-09-26
- Đã hoàn thiện về ý tưởng: các role, các usecases
- Đã phác thảo được DB, về phần comment thì quyết định sẽ dùng SQL với bảng comments:
    + Bảng comments có trường parent_id, có 3 level comment: comment thẳng vào post, reply lvl1 và reply lvl2
    + Bảng comments sẽ có trường parent_id, với comment thẳng vào post thì parent_id là null
    + Về thứ tự comment thì sẽ dựa vào created_date
- 📌 Note: Ngày mai tìm hiểu về phần đầu mục, text in đậm, ảnh, Table of contents của 1 bài post
