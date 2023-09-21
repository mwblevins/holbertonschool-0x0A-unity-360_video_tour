using UnityEngine;

public class RoomSwitcher : MonoBehaviour
{
    public GameObject livingRoom;
    public GameObject cantina;
    public GameObject cube;
    public GameObject mezzanine;

    public void SwitchToLivingRoom()
    {
        ActivateRoom(livingRoom);
        DeactivatePreviousRooms(livingRoom);
    }

    public void SwitchToCantina()
    {
        ActivateRoom(cantina);
        DeactivatePreviousRooms(cantina);
    }

    public void SwitchToCube()
    {
        ActivateRoom(cube);
        DeactivatePreviousRooms(cube);
    }

    public void SwitchToMezzanine()
    {
        ActivateRoom(mezzanine);
        DeactivatePreviousRooms(mezzanine);
    }

    private void ActivateRoom(GameObject room)
    {
        room.SetActive(true);
    }

    private void DeactivatePreviousRooms(GameObject currentRoom)
    {
        GameObject[] rooms = { livingRoom, cantina, cube, mezzanine };

        foreach (GameObject room in rooms)
        {
            if (room != currentRoom)
            {
                room.SetActive(false);
            }
        }
    }
}
