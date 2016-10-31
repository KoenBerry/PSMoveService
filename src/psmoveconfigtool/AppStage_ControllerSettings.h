#ifndef APP_STAGE_CONTROLLER_SETTINGS_H
#define APP_STAGE_CONTROLLER_SETTINGS_H

//-- includes -----
#include "AppStage.h"
#include "ClientPSMoveAPI.h"

#include <vector>

//-- definitions -----
class AppStage_ControllerSettings : public AppStage
{
public:
    struct ControllerInfo
    {
        int ControllerID;
        ClientControllerView::eControllerType ControllerType;
        PSMoveTrackingColorType TrackingColorType;
        std::string DevicePath;
        std::string DeviceSerial;
        std::string AssignedHostSerial;
        bool PairedToHost;
		int PositionFilterIndex;
		std::string PositionFilterName;
		int OrientationFilterIndex;
		std::string OrientationFilterName;
    };

    AppStage_ControllerSettings(class App *app);

    inline const ControllerInfo *getSelectedControllerInfo() const
    { 
        return 
            (m_selectedControllerIndex != -1) 
            ? &m_bluetoothControllerInfos[m_selectedControllerIndex] 
            : nullptr; 
    }

    virtual void enter() override;
    virtual void exit() override;
    virtual void update() override;
    virtual void render() override;

    virtual void renderUI() override;

    static const char *APP_STAGE_NAME;

protected:
    virtual bool onClientAPIEvent(
        ClientPSMoveAPI::eEventType event, 
        ClientPSMoveAPI::t_event_data_handle opaque_event_handle) override;

    void request_controller_list();
    static void handle_controller_list_response(
        const ClientPSMoveAPI::ResponseMessage *response_message,
        void *userdata);
	void request_set_orientation_filter(const int controller_id, const std::string &filter_name);
	void request_set_position_filter(const int controller_id, const std::string &filter_name);

private:
    enum eControllerMenuState
    {
        inactive,
        idle,

        pendingControllerListRequest,
        failedControllerListRequest,
    };
    eControllerMenuState m_menuState;

    std::vector<ControllerInfo> m_bluetoothControllerInfos;
    std::vector<ControllerInfo> m_usbControllerInfos;
    std::string m_hostSerial;

    int m_selectedControllerIndex;
};

#endif // APP_STAGE_SELECT_CONTROLLER_H