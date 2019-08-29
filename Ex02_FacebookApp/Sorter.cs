using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace Ex02_FacebookApp
{
    public static class Sorter
    {
        public static Status[] GetStatusesSortedByLikesCount
            (FacebookObjectCollection<Status> i_OriginalStatuses)
        {
            Status[] sortedStatuses = getStatusesAsArray(i_OriginalStatuses);
            try
            {
                mergeSort(sortedStatuses, "likesCount");
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return sortedStatuses;
        }

        public static Status[] GetStatusesSortedByCommentsCount(FacebookObjectCollection<Status> i_OriginalStatuses)
        {
            Status[] sortedStatuses = getStatusesAsArray(i_OriginalStatuses);
            try
            {
                mergeSort(sortedStatuses, "commentsCount");
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return sortedStatuses;
        }

        private static Status[] getStatusesAsArray
            (FacebookObjectCollection<Status> i_OriginalStatuses)
        {
            Status[] statusesArray = new Status[i_OriginalStatuses.Count];
            for (int i = 0; i < i_OriginalStatuses.Count; i++)
            {
                statusesArray[i] = i_OriginalStatuses[i];
            }

            return statusesArray;
        }

        private static void mergeSort(Status[] i_StatusesArray, string i_SortBy)
        {
            mergeSort(i_StatusesArray, 0, i_StatusesArray.Length - 1, i_SortBy);
        }

        private static void mergeSort(Status[] i_StatusesArray, int i_Low, int i_High, string i_SortBy)
        {
            if (i_Low < i_High)
            {
                int middle = (i_Low / 2) + (i_High / 2);
                mergeSort(i_StatusesArray, i_Low, middle, i_SortBy);
                mergeSort(i_StatusesArray, middle + 1, i_High, i_SortBy);
                merge(i_StatusesArray, i_Low, middle, i_High, i_SortBy);
            }
        }

        private static void merge(Status[] i_StatusesArray, int i_Low, int i_Middle, int i_High, string i_SortBy)
        {
            int left = i_Low;
            int right = i_Middle + 1;
            Status[] tmp = new Status[(i_High - i_Low) + 1];
            int tmpIndex = 0;

            while ((left <= i_Middle) && (right <= i_High))
            {
                if (i_SortBy == "likesCount")
                {
                    if (i_StatusesArray[left].LikedBy.Count > i_StatusesArray[right].LikedBy.Count)
                    {
                        tmp[tmpIndex] = i_StatusesArray[left];
                        left = left + 1;
                    }
                    else
                    {
                        tmp[tmpIndex] = i_StatusesArray[right];
                        right = right + 1;
                    }

                    tmpIndex = tmpIndex + 1;
                }
                else if(i_SortBy == "commentsCount")
                {
                    if (i_StatusesArray[left].Comments.Count > i_StatusesArray[right].Comments.Count)
                    {
                        tmp[tmpIndex] = i_StatusesArray[left];
                        left = left + 1;
                    }
                    else
                    {
                        tmp[tmpIndex] = i_StatusesArray[right];
                        right = right + 1;
                    }

                    tmpIndex = tmpIndex + 1;
                }
                else
                {
                    throw new Exception(string.Format("sorting by {0} is not valid!", i_SortBy));
                }
            }

            if (left <= i_Middle)
            {
                while (left <= i_Middle)
                {
                    tmp[tmpIndex] = i_StatusesArray[left];
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            if (right <= i_High)
            {
                while (right <= i_High)
                {
                    tmp[tmpIndex] = i_StatusesArray[right];
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                i_StatusesArray[i_Low + i] = tmp[i];
            }
        }
    }
}
