using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AWSBucketsTests_DAL
{
    public class Buckets_DAL
    {
        private IAmazonS3 _s3Client;

        public Buckets_DAL()
        {
            _s3Client = new AmazonS3Client(Constants.UID, Constants.SECRET, RegionEndpoint.USEast1);
        }

        public async Task<List<string>> GetBuckets()
        {
            List<string> buckets = new List<string>();
            var response = await _s3Client.ListBucketsAsync();
            response.Buckets.ForEach(bucket => { buckets.Add(bucket.BucketName); });
            return buckets;
        }

        public async Task<List<string>> GetItemsBucket(string bucketName)
        {
            List<string> items = new List<string>();
            ListObjectsV2Request request = new ListObjectsV2Request() { BucketName = bucketName };
            ListObjectsV2Response response = await _s3Client.ListObjectsV2Async(request);
            response.S3Objects.ForEach(item => { items.Add(item.Key); });
            return items;
        }

        public async Task<bool> DownloadItemBucket(string bucketName, string itemKey, string basePath)
        {
            GetObjectRequest request = new GetObjectRequest() { BucketName = bucketName, Key = itemKey };
            GetObjectResponse response = await _s3Client.GetObjectAsync(request);

            try
            {
                await response.WriteResponseStreamToFileAsync($"{basePath+"//"+itemKey}", true, CancellationToken.None);
                return response.HttpStatusCode == System.Net.HttpStatusCode.OK;
            }
            catch (AmazonS3Exception)
            {
                return false;
            }

        }

        public async Task<bool> UploadItemBucket(string bucketName, string itemKey, string basePath)
        {
            PutObjectRequest request = new PutObjectRequest() { BucketName = bucketName, Key = itemKey, FilePath = basePath};
            PutObjectResponse response = await _s3Client.PutObjectAsync(request);

            if (response.HttpStatusCode == System.Net.HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> DeleteItemBucket(string bucketName, string itemKey)
        {
            try
            {
                DeleteObjectRequest request = new DeleteObjectRequest() { BucketName = bucketName, Key = itemKey };
                DeleteObjectResponse response = await _s3Client.DeleteObjectAsync(request);
                return true;
            }
            catch (AmazonS3Exception)
            {
                return false;
            }
        }

        public async Task<bool> CreateBucket(string bucketName)
        {
            try
            {
                PutBucketRequest request = new PutBucketRequest() { BucketName = bucketName, UseClientRegion = true };
                PutBucketResponse response = await _s3Client.PutBucketAsync(request);
                return true;
            }
            catch (AmazonS3Exception)
            {
                return false;
            }
        }

        public async Task<bool> CreateFolder(string bucketName, string folderName)
        {
            try
            {
                PutObjectRequest request = new PutObjectRequest() { BucketName = bucketName, Key = folderName + "/" };
                PutObjectResponse response = await _s3Client.PutObjectAsync(request);
                return true;
            }
            catch (AmazonS3Exception)
            {
                return false;
            }
        }
    }
}
