using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class JournalTask
{
    public string Description;
    public int ItemIndex = -1;
    public int DoorIndex = -1;
    public int relatedTask = -1;
}

public class Journal : MonoBehaviour
{
    public Text text;
    public DTInventory.DTInventory inventory;
    public JournalTask[] Tasks;

    public string TextCompleteAllTask = "All Tasks were Completed";

    static private List<int> openedDoors = new List<int>();

    private int currentTaskIndex = 0;

    static public void AddOpenedDoorIndex(int index)
    {
        if (!openedDoors.Contains(index))
        {
            openedDoors.Add(index);
        }
    }

    private void Update()
    {
        JournalTask currentTask = GetCurrentTask();

        if (currentTask == null)
        {
            text.text = TextCompleteAllTask;
            return;
        }

        text.text = currentTask.Description;

        if (IsTaskComplete(currentTask))
        {
            currentTaskIndex++;
        }
    }

    JournalTask GetCurrentTask()
    {
        if (currentTaskIndex < Tasks.Length)
        {
            return Tasks[currentTaskIndex];
        }

        return null;
    }

    bool IsTaskComplete(JournalTask task)
    {
        if (IsPartTaskComplete(task))
        {
            return true;
        }

        if (task.relatedTask != -1 && !IsTaskComplete(Tasks[task.relatedTask]))
        {
            currentTaskIndex = task.relatedTask;
        }
        
        return false;
    }

    bool IsPartTaskComplete(JournalTask task)
    {
        if (task.DoorIndex != -1 && !openedDoors.Contains(task.DoorIndex))
        {
            return false;
        }

        if (task.ItemIndex != -1 && !inventory.HasItem(task.ItemIndex))
        {
            return false;
        }

        return true;
    }
}