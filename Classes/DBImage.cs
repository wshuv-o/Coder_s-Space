using media.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace media
{
    public class DBImage
    {
        private string ConnectionString = "server=localhost;user=root;database=csdb;port=3306;password=";
        private int userId;
        private Image image;
        public int UserId
        {
            get { return this.userId; }
            set { this.userId = value; }
        }
        public Image Image
        {
            get { return this.image; }
            set { this.image = value; }
        }


        public Image SelectImageFromFile()
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files (*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg;*.png;*.gif";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    image = Image.FromFile(dialog.FileName);
                }
            }
            return image;
        }

        public void SaveToDataBase(int userId,Image image1)
        {
            this.UserId = userId;
            if (image1 == null)
            {
                MessageBox.Show("Please select an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] imageBytes = ImageToByteArray(image1);
            UpdateUserImage(imageBytes, this.UserId);
            MessageBox.Show("Image saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public Image LoadImageFromDataBase(int userId)
        {
            this.UserId = userId;
            byte[] imageBytes = GetUserImage(this.UserId);

            if (imageBytes == null)
            {
                //MessageBox.Show("No image found for user ID " + userId + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            image = ByteArrayToImage(imageBytes);
            return image;
        }

        public byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, image.RawFormat);
                return stream.ToArray();
            }
        }

        public void UpdateUserImage(byte[] imageBytes, int userId)
        {
            this.UserId = userId;

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "UPDATE user SET user_photo = @userimage WHERE user_id = @userId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userimage", imageBytes);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public byte[] GetUserImage(int userId)
        {
            this.UserId = userId;

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT user_photo FROM user WHERE user_id = @userId";
               
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);

                    using (MySqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                return (byte[])reader[0];
                            }
                        }
                    }
                }
            }

            return null;
        }

        private Image ByteArrayToImage(byte[] imageBytes)
        {
            using (MemoryStream stream = new MemoryStream(imageBytes))
            {
                return Image.FromStream(stream);
            }
        }
    }
}