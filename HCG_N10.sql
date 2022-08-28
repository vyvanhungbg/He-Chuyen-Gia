﻿Use master
GO

CREATE DATABASE HCG_N10
GO

USE HCG_N10
GO
--DROP DATABASE HCG_N10
--DROP TABLE TapLuat
CREATE TABLE SuKien(
	MaSuKien varchar(10) not null PRIMARY KEY,
	MoTa nvarchar(100) not null,
	LoaiSuKien varchar(10) not null
)
GO

CREATE TABLE TapLuat(
	MaLuat varchar(10) not null PRIMARY KEY,
	NoiDung nvarchar(100) not null
)
GO

--Bang SuKien
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NXB1', N'NXB Kim Đồng',   'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NXB2', N'NXB Thanh Niên', 'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NXB3', N'NXB Lao Động',   'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NXB4', N'NXB Tư Pháp',    'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NXB5', N'NXB Quân Đội',   'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NXB6', N'NXB Trẻ',        'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NBX7', N'NXB VH-NT',      'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NBX8', N'NXB Đà nẵng',    'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NBX9', N'NXB Công thương','NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NBX10', N'NXB Thế Giới',  'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NBX11', N'NXB Tổng hợp TP.HCM','NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NBX12', N'NXB Phụ nữ',         'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NXB13', N'NXB Nhã Nam',        'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NXB14', N'NXB Sky Book',       'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NXB15', N'NXB Trí Tuệ',        'NhaXuatBan')
GO

INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TL1', N'Chính trị - Pháp luật',    'TheLoai')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TL2', N'Khoa học công nghẹ',       'TheLoai')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TL3', N'Kinh tế',                  'TheLoai')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TL4', N'Văn học - Nghệ thuật',     'TheLoai')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TL5', N'Văn hóa xã hội - Lịch sử', 'TheLoai')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TL6', N'Truyện - Tiểu thuyết',     'TheLoai')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TL7', N'Thiếu nhi',                'TheLoai')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TL8',N'Kỹ năng sống',    'TheLoai')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TL9',N'Tâm lí',    'TheLoai')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TL10',N'Du kí',    'TheLoai')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TL11', N'Phụ nữ','Sach')
Go

INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('GT1', N'< 100 nghìn',     'GiaTien')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('GT2', N'100 - 200 nghìn', 'GiaTien')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('GT3', N'200 - 300 nghìn', 'GiaTien')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('GT4', N'300 - 400 nghìn', 'GiaTien')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('GT5', N'400 - 500 nghìn', 'GiaTien')

GO



INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG1', N'Nguyễn Nhật Ánh','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG2', N'Peter Frankopan','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG3', N'Dale Carnegie','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG4', N'S J Scott','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG5', N'Phan Văn Trường','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG6', N'Lieberman','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG7', N'Nguyễn Thế Quang','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG8', N'Lý thành cơ','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG9', N'Trần Trọng Kim','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG10', N'Đặng Quân','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG11', N'Hà Giang','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG12', N'Nguyễn Thủy Chung','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG13', N'Tô Hoài','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG14', N'James F. O’brien','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG15', N'Manh Chu','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG16', N'Osho','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG17', N'Haruki','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG18', N'Nhật Phong','TacGia')
GO

INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('MD0', N'-',   'MucDich')
GO


INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NN1', N'Kinh doanh', 'NgheNghiep')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NN2', N'Kỹ sư',      'NgheNghiep')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NN3', N'Học sinh',   'NgheNghiep')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NN4', N'Luật sư',    'NgheNghiep')
GO

INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('DT1', N'6-11 tuổi',    'DoTuoi')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('DT2', N'11-15 tuổi',   'DoTuoi')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('DT3', N'15-18 tuổi',   'DoTuoi')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('DT4', N'trên 18 tuổi', 'DoTuoi')

GO

INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S1', N'Truyện ngụ ngôn Aesop','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S2', N'Thiên đường có thật','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S3', N'Sự nghiệp là một trò chơi','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S4', N'Con đường tơ lụa','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S5', N'Con đường không tắt nắng','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S6', N'Cuộc Thập Tự Chinh Thứ Nhất - Tiếng Gọi Từ Phương Đông','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S7', N'Con Đường Tơ Lụa Mới - Hiện Tại Và Tương lai Của Thế Giới Mới','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S8', N'Cuốn theo chiều gió','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S9', N'Cha giàu cha nghèo','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S10', N'Đắc nhân tâm',             'Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S11', N'Luật kinh tế',              'Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S12', N'Internet vạn vật',			'Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S13', N'Trở về từ cõi sáng',		'Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S14', N'Mắt biếc',					'Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S15', N'Truyện cổ tích',			'Sach')
GO
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S16', N'Đừng Để Mục Tiêu Như Diều Không Gió','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S17', N'Một đời như kẻ tìm đường','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S18', N'Đọc vị Bất kì ai','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S19', N'Thông reo ngàn hống','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S20', N'Mộ,t đời quản trị','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S21', N'Nguyễn Du','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S22', N'Chuyện những người An nam ở Paris Hay sự thật về đông dương','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S23', N'Chuỗi thói quen','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S24', N'Tuổi Trẻ Trong Ví, Bạn Mua Được Gì?','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S25', N'Thế Giới Rộng Lớn Đừng Đi Một Mình','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S26', N'Cho Tôi Xin Một Vé Đi Tuổi Thơ','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S27', N'Đừng Lựa Chọn An Nhàn Khi Còn Trẻ','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S28', N'Nóng Giận Là Bản Năng , Tĩnh Lặng Là Bản Lĩnh','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S29', N'Quẳng Gánh Lo Đi Và Vui Sống','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S30', N'Việt Nam Sử Lược (Bản Đặc Biệt)','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S31', N'Tôi thấy hoa vàng trên cỏ xanh','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S32', N'Quê Nhà','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S33', N'Dế Mèn Phiêu Lưu Ký','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S34', N'TRÍ TUỆ SHERLOCK HOLMES','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S35', N'Kafa','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S36', N'Tiếng chim hót trong bụi','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S37', N'Giải mã bí ẩn phái đẹp','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S38', N'Truyện Grim','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S39', N'Saitama','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S40', N'Quy tắc 4 giờ','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S41', N'Ngày hôm qua','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S42', N'Khi người lớn cô đơn','Sach')
GO
--Bang TapLuat
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R1',N'NN1>TL3')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R2',N'NN3^DT1>TL7')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R3',N'NN4>TL9')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R4',N'NN2>TL2')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R5',N'DT1>TL7')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R6',N'DT2>TL6')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R7',N'DT3>TL2')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R8',N'DT4^NN4>TL1')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R9',N'DT3>NN3')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R10',N'TL8^NXB2>TG4')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R11',N'TG5^GT2^NXB6>TL8')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R12',N'TL6^NXB6>GT2')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R13',N'GT2^TL5>NXB6')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R14',N'TL5^NXB8>DT4')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R15',N'TG4^NXB9>GT2')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R16',N'TG8>GT1')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R17',N'TL10^GT1>TG8')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R18',N'TG8^NXB12>TL10')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R19',N'NXB10^DT3>TL8')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R20',N'DT2^NXB1>TL7')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R21',N'NXB6^DT3>TL6')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R22',N'DT3^NXB1>TL5')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R23',N'TG13>NXB1')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R24',N'TL6^DT4>GT2')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R25',N'TL6>DT3')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R26',N'GT2^TG10>NXB10')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R27',N'DT4>NXB11')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R28',N'TG1>NXB6')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R29',N'TG18^NXB13>GT2')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R30',N'TL6^DT1>TG18')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R31',N'NXB14^GT3>DT4')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R32',N'GT1^TL11^DT2>NXB13')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R33',N'TG18^GT2>DT3')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R34',N'TG18^TL6^DT1>GT1')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R35',N'NXB1^DT1>S1')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R36',N'NXB3^GT4>S11')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R37',N'TG1^GT5>S14')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R38',N'TG11^NXB7>S8')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R39',N'TG3^TL9^NXB1>S10')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R40',N'DT2^NN3>S1')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R41',N'TG2^GT1^TL7>S1')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R42',N'TL5^DT3>S7')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R43',N'GT3^TL4>S9')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R44',N'NXB5^GT3>S6')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R45',N'TL8^TG10^DT3>S3')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R46',N'NXB2^DT3>S12')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R47',N'NXB1^DT1>S1')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R48',N'NXB6^TG1^NN3>S14')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R49',N'NXB4^NN4^TL3>S11')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R50',N'TG2^TL6>S6')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R51',N'GT1^TG2>S3')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R52',N'GT2^TG3>S4')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R53',N'TG1^TL6>S14')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R54',N'GT4^NN1>S10')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R55',N'GT5^NN3>S15')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R56',N'DT4^TG10>S3')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R57',N'DT1^TG3>S15')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R58',N'DT4^TL1>NN4')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R59',N'GT4^NN1>S13')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R60',N'GT2^DT4>S5')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R61',N'TG4^GT1>S16')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R62',N'TL8^DT3>S17')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R63',N'TG6^NXB6>S18')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R64',N'GT2^TG7>S19')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R65',N'TL3^TG5>S20')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R66',N'TL5^TG7>S21')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R67',N'DT4^TL9>S22')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R68',N'TG4^TL8^GT2>S23')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R69',N'TG8^NXB7>S24')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R70',N'TL10^TG8>S25')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R71',N'NXB10^TG10^TL8>S27')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R72',N'TG11^GT1^TL8>S28')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R73',N'TG3^GT2^TL8>S29')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R74',N'NXB1^TL5^TG9>S30')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R75',N'TG1^GT2^TL6>S31')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R76',N'NXB1^GT1^TG13>S33')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R77',N'TL7^GT2^NXB1>S32')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R78',N'TG14^TL6>S34')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R79',N'TG1^TL6^GT1>S26')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R80',N'TG15^NXB13^GT1>S35')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R81',N'TG15^TL11^DT1>S36')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R82',N'GT2^TL11^DT3>S37')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R83',N'TG18^NXB14^GT1>S38')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R84',N'DT4^TG18>S39')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R85',N'NXB13^TG18>S40')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R86',N'DT3^TG17^NSX16^TL11>S41')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R87',N'GT1^NXB13>S42')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R88',N'GT1^NXB14>S42')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R89',N'TG18^NXB14>S37')
INSERT INTO TapLuat(MaLuat, NoiDung) VALUES ('R90',N'DT3^TG15>S42')
GO

select * from SuKien
select * from TapLuat