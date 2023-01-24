# Buckets AWS S3 SDK Examples
A little application with some examples and implementation of AWS S3 SDK.

## Prerequisites

Use with personal account for testing.

* Create a Group and User in AWS IAM Users. [Documentation](https://docs.aws.amazon.com/IAM/latest/UserGuide/id_groups.html)
* Configure an Access Key for the user in AWS IAM Users. [Documentation](https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_access-keys.html)
* Configure permissions policy to the group created

The permissions for the group can be configured using the following JSON

```JSON
{
    "Version": "2012-10-17",
    "Statement": [
        {
            "Sid": "VisualEditor0",
            "Effect": "Allow",
            "Action": [
                "s3:ListAccessPointsForObjectLambda",
                "s3:GetAccessPoint",
                "s3:PutAccountPublicAccessBlock",
                "s3:ListAccessPoints",
                "s3:*",
                "s3:*Object*",
                "s3:ListJobs",
                "s3:PutStorageLensConfiguration",
                "s3:ListMultiRegionAccessPoints",
                "s3:ListStorageLensConfigurations",
                "s3:GetAccountPublicAccessBlock",
                "s3:ListAllMyBuckets",
                "s3:PutAccessPointPublicAccessBlock",
                "s3:CreateJob"
            ],
            "Resource": "*"
        },
        {
            "Sid": "VisualEditor1",
            "Effect": "Allow",
            "Action": "s3:*",
            "Resource": "*"
        }
    ]
}
```

This policy allows to users in the group access for all actions.

Finally update the lines in the class `Constants` with the data provided by AWS at the moment of the configuration of the Access Key.

```C#
public static string UID = "";
public static string SECRET = "";
```