NLogPushoverTarget
==================

A custom target for sending NLog logs as notifications to Pushover (https://psuhover.net)

by Martin Gadd


This package can be used to let Nlog send notifications to Pushover

The included pushover.dll comes from Pushover.NET at https://pushover.codeplex.com/

STEPS:
1. Create and Pushover account (https://pushover.net)
2. Install Pushover on your phone
3. Create a new application at your Pushover account
4. Extract the includes dlls in the same directory as your NLog.dll
5. Edit the Pushover target with at least your user key (from Step 1.)  and application Key (Step 3.)
6. Test by letting your application create an Logging event.
7. Should you experience errors; logging is made to NLog's internal logger (https://github.com/NLog/NLog/wiki/Internal-Logging)


