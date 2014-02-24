NLogPushoverTarget
==================


<a href="https://github.com/MartinGadd/NLogPushoverTarget/blob/master/bin/NLogPushoverTarget_v1.0.00.zip?raw=true">Download v.1.0.00</a>







Description
-----------

A custom target for sending NLog logs as notifications to Pushover (https://pushover.net)

Requirements
------------

* `NLog` (version 2.0.0 and later)

Third Party Dlls
---------------

pushover.dll comes from Pushover.NET at https://pushover.codeplex.com/

NLog.dll comes from NLog at https://github.com/NLog/NLog


Intallation & Configuration
--------------------------

  1. Create a Pushover account (https://pushover.net)

  2. Install Pushover on your phone

  3. Create a new application at your Pushover account

  4. Extract the includes dlls in the same directory as your NLog.dll

  5. Edit the Pushover target with at least your user key (from Step 1.)  and application Key (Step 3.)<br/>

  6. Test by letting your application create an Logging event.

  7. Should you experience errors; logging is made to NLog's internal logger (https://github.com/NLog/NLog/wiki/Internal-Logging)

Author
------

Martin Gadd <gadd.martin@gmail.com>

License
-------

The MIT License (MIT)

Copyright (c) 2014 Martin Gadd

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.


