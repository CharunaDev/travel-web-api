---- SAMPLE DATA -------
--- Destination 
INSERT INTO Destinations (Name, Description, Province, City,IsActive, CreateDate, UpdatedDate) VALUES 
('Sigiriya', 'Ancient rock fortress in central Sri Lanka', 'Central Province', 'Sigiriya',1,GETDATE(),GETDATE()),
('Galle Fort', 'A historical, Dutch colonial fortress in Sri Lanka', 'Southern Province', 'Galle',1,GETDATE(),GETDATE()),
('Kandy', 'Cultural capital of Sri Lanka known for the Temple of the Tooth', 'Central Province', 'Kandy',1,GETDATE(),GETDATE()),
('Colombo', 'The bustling commercial capital of Sri Lanka', 'Western Province', 'Colombo',1,GETDATE(),GETDATE()),
('Ella', 'A small town in the Badulla District known for hiking and nature', 'Uva Province', 'Ella',1,GETDATE(),GETDATE());


--- Hotel

INSERT INTO Hotels (Name, Address, Description, Rating, IsActive, CreateDate, UpdatedDate) VALUES 
('Hotel Sigiriya', '123 Rock Fortress Road, Sigiriya', 'Luxury hotel with stunning views of Sigiriya Rock', 4.5,1,GETDATE(),GETDATE()),
('Amangalla', 'Main St, Galle Fort, Galle', '5-star hotel in the heart of Galle Fort', 4.8,1,GETDATE(),GETDATE()),
('Kandy City Hotel', '45 Temple Rd, Kandy', 'Boutique hotel in the center of Kandy city', 4.2,1,GETDATE(),GETDATE()),
('Colombo Hilton', 'No 2, Sir Chittampalam A Gardiner Mawatha, Colombo', 'Luxurious hotel located in Colombo', 4.7,1,GETDATE(),GETDATE()),
('98 Acres Resort', 'Passara Rd, Ella', 'Beautiful resort located near the famous Nine Arches Bridge', 4.9, 1,GETDATE(),GETDATE());

--- Room

INSERT INTO Rooms (RoomType, Price, IsAvailable, HotelId,CreateDate,UpdatedDate) VALUES 
('Single', 120.00, 1, 2,GETDATE(),GETDATE()), -- Hotel Sigiriya
('Double', 180.00, 1, 2,GETDATE(),GETDATE()),
('Suite', 300.00, 1, 2,GETDATE(),GETDATE()),

('Single', 250.00, 1, 3,GETDATE(),GETDATE()), -- Amangalla
('Double', 350.00, 1, 3,GETDATE(),GETDATE()),
('Suite', 500.00, 0, 3,GETDATE(),GETDATE()),

('Single', 100.00, 1, 4,GETDATE(),GETDATE()), -- Kandy City Hotel
('Double', 150.00, 0, 4,GETDATE(),GETDATE()),

('Single', 200.00, 1, 5,GETDATE(),GETDATE()), -- Colombo Hilton
('Double', 300.00, 1, 5,GETDATE(),GETDATE()),
('Suite', 450.00, 1, 5,GETDATE(),GETDATE()),

('Single', 220.00, 1, 6,GETDATE(),GETDATE()), -- 98 Acres Resort
('Double', 300.00, 1, 6,GETDATE(),GETDATE()),
('Suite', 550.00, 0, 6,GETDATE(),GETDATE());
