﻿using HassClient.Helpers;
using HassClient.Models;
using NUnit.Framework;
using System;

namespace HassClient.Core.Tests
{
    [TestFixture(TestOf = typeof(KnownEnumHelpers))]
    class KnownEnumHelpersTests
    {
        [Test]
        [TestCase("area_registry_updated")]
        [TestCase("automation_reloaded")]
        [TestCase("call_service")]
        [TestCase("component_loaded")]
        [TestCase("core_config_updated")]
        [TestCase("device_registry_updated")]
        [TestCase("entity_registry_updated")]
        [TestCase("homeassistant_close")]
        [TestCase("homeassistant_final_write")]
        [TestCase("homeassistant_start")]
        [TestCase("homeassistant_stop")]
        [TestCase("logbook_entry")]
        [TestCase("lovelace_updated")]
        [TestCase("panels_updated")]
        [TestCase("persistent_notifications_updated")]
        [TestCase("platform_discovered")]
        [TestCase("service_executed")]
        [TestCase("service_registered")]
        [TestCase("service_removed")]
        [TestCase("scene_reloaded")]
        [TestCase("state_changed")]
        [TestCase("themes_updated")]
        [TestCase("time_changed")]
        [TestCase("timer_out_of_sync")]
        [TestCase("user_removed")]
        public void AllKnownEventTypesCanBeParsed(string snakeCaseValue)
        {
            var result = snakeCaseValue.AsKnownEventType();
            Assert.AreNotEqual(KnownEventTypes.Any, result);
        }

        [Test]
        public void NullStringAsEventTypeThrows()
        {
            Assert.Throws<ArgumentException>(() => ((string)null).AsKnownEventType());
        }

        [Test]
        public void EmptyStringAsEventTypeThrows()
        {
            Assert.Throws<ArgumentException>(() => string.Empty.AsKnownEventType());
        }

        [Test]
        [TestCase("adguard")]
        [TestCase("air_quality")]
        [TestCase("alarm_control_panel")]
        [TestCase("automation")]
        [TestCase("binary_sensor")]
        [TestCase("calendar")]
        [TestCase("camera")]
        [TestCase("cast")]
        [TestCase("climate")]
        [TestCase("cloud")]
        [TestCase("counter")]
        [TestCase("cover")]
        [TestCase("device_tracker")]
        [TestCase("esphome")]
        [TestCase("fan")]
        [TestCase("filesize")]
        [TestCase("frontend")]
        [TestCase("generic")]
        [TestCase("generic_thermostat")]
        [TestCase("group")]
        [TestCase("hassio")]
        [TestCase("homeassistant")]
        [TestCase("html5")]
        [TestCase("humidifier")]
        [TestCase("image_processing")]
        [TestCase("input_boolean")]
        [TestCase("input_datetime")]
        [TestCase("input_number")]
        [TestCase("input_select")]
        [TestCase("input_text")]
        [TestCase("light")]
        [TestCase("lock")]
        [TestCase("logbook")]
        [TestCase("logger")]
        [TestCase("mailbox")]
        [TestCase("media_player")]
        [TestCase("mqtt")]
        [TestCase("notify")]
        [TestCase("number")]
        [TestCase("persistent_notification")]
        [TestCase("person")]
        [TestCase("python_script")]
        [TestCase("recorder")]
        [TestCase("remote")]
        [TestCase("scene")]
        [TestCase("script")]
        [TestCase("sensor")]
        [TestCase("speedtestdotnet")]
        [TestCase("stream")]
        [TestCase("sun")]
        [TestCase("switch")]
        [TestCase("system_log")]
        [TestCase("template")]
        [TestCase("timer")]
        [TestCase("tts")]
        [TestCase("vacuum")]
        [TestCase("wake_on_lan")]
        [TestCase("water_heater")]
        [TestCase("weather")]
        [TestCase("webos_tv")]
        [TestCase("xiaomi_miio")]
        [TestCase("zha")]
        [TestCase("zone")]
        public void AllKnownDomainsCanBeParsed(string snakeCaseValue)
        {
            var result = snakeCaseValue.AsKnownDomain();
            Assert.AreNotEqual(KnownDomains.Undefined, result);
        }

        [Test]
        public void NullStringAsKnownDomainThrows()
        {
            Assert.Throws<ArgumentException>(() => ((string)null).AsKnownDomain());
        }

        [Test]
        public void EmptyStringAsKnownDomainThrows()
        {
            Assert.Throws<ArgumentException>(() => string.Empty.AsKnownDomain());
        }

        [Test]
        [TestCase("create")]
        [TestCase("decrement")]
        [TestCase("dismiss")]
        [TestCase("increment")]
        [TestCase("pause")]
        [TestCase("record")]
        [TestCase("reload")]
        [TestCase("remove")]
        [TestCase("send_command")]
        [TestCase("set_value")]
        [TestCase("start")]
        [TestCase("stop")]
        [TestCase("toggle")]
        [TestCase("turn_off")]
        [TestCase("turn_on")]
        [TestCase("add_url")]
        [TestCase("disable_url")]
        [TestCase("enable_url")]
        [TestCase("refresh")]
        [TestCase("remove_url")]
        [TestCase("trigger")]
        [TestCase("disable_motion_detection")]
        [TestCase("enable_motion_detection")]
        [TestCase("play_stream")]
        [TestCase("snapshot")]
        [TestCase("show_lovelace_view")]
        [TestCase("set_aux_heat")]
        [TestCase("set_fan_mode")]
        [TestCase("set_humidity")]
        [TestCase("set_hvac_mode")]
        [TestCase("set_preset_mode")]
        [TestCase("set_swing_mode")]
        [TestCase("set_temperature")]
        [TestCase("remote_connect")]
        [TestCase("remote_disconnect")]
        [TestCase("configure")]
        [TestCase("reset")]
        [TestCase("close_cover")]
        [TestCase("close_cover_tilt")]
        [TestCase("open_cover")]
        [TestCase("open_cover_tilt")]
        [TestCase("set_cover_position")]
        [TestCase("set_cover_tilt_position")]
        [TestCase("stop_cover")]
        [TestCase("stop_cover_tilt")]
        [TestCase("toggle_cover_tilt")]
        [TestCase("see")]
        [TestCase("decrease_speed")]
        [TestCase("increase_speed")]
        [TestCase("oscillate")]
        [TestCase("set_direction")]
        [TestCase("set_percentage")]
        [TestCase("set_speed")]
        [TestCase("reload_themes")]
        [TestCase("set_theme")]
        [TestCase("set")]
        [TestCase("addon_restart")]
        [TestCase("addon_start")]
        [TestCase("addon_stdin")]
        [TestCase("addon_stop")]
        [TestCase("host_reboot")]
        [TestCase("host_shutdown")]
        [TestCase("restore_full")]
        [TestCase("restore_partial")]
        [TestCase("snapshot_full")]
        [TestCase("snapshot_partial")]
        [TestCase("check_config")]
        [TestCase("reload_core_config")]
        [TestCase("restart")]
        [TestCase("set_location")]
        [TestCase("update_entity")]
        [TestCase("set_datetime")]
        [TestCase("select_first")]
        [TestCase("select_last")]
        [TestCase("select_next")]
        [TestCase("select_option")]
        [TestCase("select_previous")]
        [TestCase("set_options")]
        [TestCase("lock")]
        [TestCase("open")]
        [TestCase("unlock")]
        [TestCase("log")]
        [TestCase("set_default_level")]
        [TestCase("set_level")]
        [TestCase("clear_playlist")]
        [TestCase("media_next_track")]
        [TestCase("media_pause")]
        [TestCase("media_play")]
        [TestCase("media_play_pause")]
        [TestCase("media_previous_track")]
        [TestCase("media_seek")]
        [TestCase("media_stop")]
        [TestCase("play_media")]
        [TestCase("repeat_set")]
        [TestCase("select_sound_mode")]
        [TestCase("select_source")]
        [TestCase("shuffle_set")]
        [TestCase("volume_down")]
        [TestCase("volume_mute")]
        [TestCase("volume_set")]
        [TestCase("volume_up")]
        [TestCase("dump")]
        [TestCase("publish")]
        [TestCase("notify")]
        [TestCase("persistent_notification")]
        [TestCase("mark_read")]
        [TestCase("purge")]
        [TestCase("delete_command")]
        [TestCase("learn_command")]
        [TestCase("apply")]
        [TestCase("speedtest")]
        [TestCase("clear")]
        [TestCase("write")]
        [TestCase("cancel")]
        [TestCase("finish")]
        [TestCase("clear_cache")]
        [TestCase("cloud_say")]
        [TestCase("google_say")]
        [TestCase("clean_spot")]
        [TestCase("locate")]
        [TestCase("return_to_base")]
        [TestCase("set_fan_speed")]
        [TestCase("start_pause")]
        [TestCase("send_magic_packet")]
        [TestCase("button")]
        [TestCase("command")]
        [TestCase("select_sound_output")]
        [TestCase("vacuum_clean_segment")]
        [TestCase("vacuum_clean_zone")]
        [TestCase("vacuum_goto")]
        [TestCase("vacuum_remote_control_move")]
        [TestCase("vacuum_remote_control_move_step")]
        [TestCase("vacuum_remote_control_start")]
        [TestCase("vacuum_remote_control_stop")]
        [TestCase("issue_zigbee_cluster_command")]
        [TestCase("issue_zigbee_group_command")]
        [TestCase("permit")]
        [TestCase("set_zigbee_cluster_attribute")]
        [TestCase("warning_device_squawk")]
        [TestCase("warning_device_warn")]
        public void AllKnownServicesCanBeParsed(string snakeCaseValue)
        {
            var result = snakeCaseValue.AsKnownService();
            Assert.AreNotEqual(KnownServices.Undefined, result);
        }

        [Test]
        public void NullStringAsKnownServiceThrows()
        {
            Assert.Throws<ArgumentException>(() => ((string)null).AsKnownService());
        }

        [Test]
        public void EmptyStringAsKnownServiceThrows()
        {
            Assert.Throws<ArgumentException>(() => string.Empty.AsKnownService());
        }

        [TestCase("above_horizon")]
        [TestCase("active")]
        [TestCase("armed")]
        [TestCase("armed_away")]
        [TestCase("armed_custom_bypass")]
        [TestCase("armed_home")]
        [TestCase("armed_night")]
        [TestCase("arming")]
        [TestCase("auto")]
        [TestCase("backed_up")]
        [TestCase("bellow_horizon")]
        [TestCase("cleaning")]
        [TestCase("clear-night")]
        [TestCase("closed")]
        [TestCase("closing")]
        [TestCase("cloudy")]
        [TestCase("configure")]
        [TestCase("configured")]
        [TestCase("cool")]
        [TestCase("dead")]
        [TestCase("disarmed")]
        [TestCase("disarming")]
        [TestCase("discharging")]
        [TestCase("docked")]
        [TestCase("dry")]
        [TestCase("eco")]
        [TestCase("error")]
        [TestCase("exceptional")]
        [TestCase("fan_only")]
        [TestCase("far")]
        [TestCase("fog")]
        [TestCase("hail")]
        [TestCase("Hans")]
        [TestCase("heat")]
        [TestCase("heat_cool")]
        [TestCase("home")]
        [TestCase("idle")]
        [TestCase("initializing")]
        [TestCase("lightning")]
        [TestCase("lightning-rainy")]
        [TestCase("locked")]
        [TestCase("none")]
        [TestCase("not_home")]
        [TestCase("notifying")]
        [TestCase("off")]
        [TestCase("ok")]
        [TestCase("on")]
        [TestCase("open")]
        [TestCase("opening")]
        [TestCase("partlycloudy")]
        [TestCase("paused")]
        [TestCase("pending")]
        [TestCase("playing")]
        [TestCase("pouring")]
        [TestCase("priority_only")]
        [TestCase("problem")]
        [TestCase("rainy")]
        [TestCase("ready")]
        [TestCase("recording")]
        [TestCase("returning")]
        [TestCase("sleeping")]
        [TestCase("snowy")]
        [TestCase("snowy-rainy")]
        [TestCase("standby")]
        [TestCase("still")]
        [TestCase("stopped")]
        [TestCase("streaming")]
        [TestCase("sunny")]
        [TestCase("triggered")]
        [TestCase("unavailable")]
        [TestCase("unknown")]
        [TestCase("unlocked")]
        [TestCase("vibrate")]
        [TestCase("windy")]
        [TestCase("windy-variant")]
        [TestCase("zoning")]
        public void AllKnownStatesCanBeParsed(string snakeCaseValue)
        {
            var result = snakeCaseValue.AsKnownState();
            Assert.AreNotEqual(KnownStates.Undefined, result);
        }

        [Test]
        public void NullStringAsKnownStateReturnsUnknown()
        {
            var result = ((string)null).AsKnownState();
            Assert.AreEqual(KnownStates.Unknown, result);
        }

        [Test]
        public void EmptyStringAsKnownStateReturnsUnknown()
        {
            var result = string.Empty.AsKnownState();
            Assert.AreEqual(KnownStates.Unknown, result);
        }
    }
}
