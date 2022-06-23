using System;
using System.Runtime.InteropServices;

namespace EButton
{
    public class Button
    {
        //ENCHIKO BUTTON DLL

        /// <summary>
        /// Simulate key press. Dont forget to activate and deactivate specific window
        /// </summary>
        /// <param name="btn">use EButton.Button.BT7 or use short value example: (short)57 </param>
        public void PressKey(BT7 btn)
        {
            Input[] array = new Input[4];
            Input input = default(Input);
            input.type = 1U;
            input.i_union.keyboardinput.wVk = (BT6)0;
            input.i_union.keyboardinput.time = 0;
            input.i_union.keyboardinput.dwExtraInfo = (UIntPtr)0UL;
            input.i_union.keyboardinput.dwFlags = BT5.SCANCODE;
            input.i_union.keyboardinput.wScan = btn;
            array[0] = input;
            SendInput(1U, array, Input.Size);
            input.i_union.keyboardinput.dwFlags = (BT5.KEYUP | BT5.SCANCODE);
            SendInput(1U, array, Input.Size);
        }

        /// <summary>
        /// Simulate key press. Dont forget to activate and deactivate specific window 
        /// </summary>
        /// <param name="btn">use EButton.Button.BT7 or use short value example: (short)57 </param>
        public void PressKey(short btn)
        {
            Input[] array = new Input[4];
            Input input = default(Input);
            input.type = 1U;
            input.i_union.keyboardinput.wVk = (BT6)0;
            input.i_union.keyboardinput.time = 0;
            input.i_union.keyboardinput.dwExtraInfo = (UIntPtr)0UL;
            input.i_union.keyboardinput.dwFlags = BT5.SCANCODE;
            input.i_union.keyboardinput.wScan = (BT7)btn;
            array[0] = input;
            SendInput(1U, array, Input.Size);
            input.i_union.keyboardinput.dwFlags = (BT5.KEYUP | BT5.SCANCODE);
            SendInput(1U, array, Input.Size);
        }

        [DllImport("user32.dll")]
        internal static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray)] [In] Input[] inputs, int size);


        public struct Input
        {
            public static int Size
            {
                get
                {
                    return Marshal.SizeOf(typeof(Input));
                }
            }

            public uint type;
            public InputUnion i_union;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct InputUnion
        {

            [FieldOffset(0)]
            internal MouseInput mouseinput;


            [FieldOffset(0)]
            internal KeyboardInput keyboardinput;


            [FieldOffset(0)]
            internal HardwareInput hardwareinput;

        }

        public struct MouseInput
        {
            internal int int_0;
            internal int int_1;
            internal BT3 btn3_0;
            internal BT4 btn4_0;
            internal uint uint_0;
            internal UIntPtr uintptr_0;
        }

        public struct KeyboardInput
        {
            internal BT6 wVk;

            internal BT7 wScan;

            internal BT5 dwFlags;

            internal int time;

            internal UIntPtr dwExtraInfo;
        }

        public struct HardwareInput
        {
            internal int int_0;

            internal short short_0;

            internal short short_1;
        }

        public enum BT2
        {
            // 04000126 RID: 294
            SM_CXSCREEN,
            // 04000127 RID: 295
            SM_CYSCREEN
        }

        [Flags]
        public enum BT3 : uint
        {
            Nothing = 0U,
            XBUTTON1 = 1U,
            XBUTTON2 = 2U
        }

        [Flags]
        public enum BT4 : uint
        {
            ABSOLUTE = 32768U,
            HWHEEL = 4096U,
            MOVE = 1U,
            MOVE_NOCOALESCE = 8192U,
            LEFTDOWN = 2U,
            LEFTUP = 4U,
            RIGHTDOWN = 8U,
            RIGHTUP = 16U,
            MIDDLEDOWN = 32U,
            MIDDLEUP = 64U,
            VIRTUALDESK = 16384U,
            WHEEL = 2048U,
            XDOWN = 128U,
            XUP = 256U
        }

        [Flags]
        public enum BT5 : uint
        {
            EXTENDEDKEY = 1U,
            KEYUP = 2U,
            SCANCODE = 8U,
            UNICODE = 4U
        }

        public enum BT6 : short
        {
            // 04000151 RID: 337
            LBUTTON = 1,
            // 04000152 RID: 338
            RBUTTON,
            // 04000153 RID: 339
            CANCEL,
            // 04000154 RID: 340
            MBUTTON,
            // 04000155 RID: 341
            XBUTTON1,
            // 04000156 RID: 342
            XBUTTON2,
            // 04000157 RID: 343
            BACK = 8,
            // 04000158 RID: 344
            TAB,
            // 04000159 RID: 345
            CLEAR = 12,
            // 0400015A RID: 346
            RETURN,
            // 0400015B RID: 347
            SHIFT = 16,
            // 0400015C RID: 348
            CONTROL,
            // 0400015D RID: 349
            MENU,
            // 0400015E RID: 350
            PAUSE,
            // 0400015F RID: 351
            CAPITAL,
            // 04000160 RID: 352
            KANA,
            // 04000161 RID: 353
            HANGUL = 21,
            // 04000162 RID: 354
            JUNJA = 23,
            // 04000163 RID: 355
            FINAL,
            // 04000164 RID: 356
            HANJA,
            // 04000165 RID: 357
            KANJI = 25,
            // 04000166 RID: 358
            ESCAPE = 27,
            // 04000167 RID: 359
            CONVERT,
            // 04000168 RID: 360
            NONCONVERT,
            // 04000169 RID: 361
            ACCEPT,
            // 0400016A RID: 362
            MODECHANGE,
            // 0400016B RID: 363
            SPACE,
            // 0400016C RID: 364
            PRIOR,
            // 0400016D RID: 365
            NEXT,
            // 0400016E RID: 366
            END,
            // 0400016F RID: 367
            HOME,
            // 04000170 RID: 368
            LEFT,
            // 04000171 RID: 369
            UP,
            // 04000172 RID: 370
            RIGHT,
            // 04000173 RID: 371
            DOWN,
            // 04000174 RID: 372
            SELECT,
            // 04000175 RID: 373
            PRINT,
            // 04000176 RID: 374
            EXECUTE,
            // 04000177 RID: 375
            SNAPSHOT,
            // 04000178 RID: 376
            INSERT,
            // 04000179 RID: 377
            DELETE,
            // 0400017A RID: 378
            HELP,
            // 0400017B RID: 379
            KEY_0,
            // 0400017C RID: 380
            KEY_1,
            // 0400017D RID: 381
            KEY_2,
            // 0400017E RID: 382
            KEY_3,
            // 0400017F RID: 383
            KEY_4,
            // 04000180 RID: 384
            KEY_5,
            // 04000181 RID: 385
            KEY_6,
            // 04000182 RID: 386
            KEY_7,
            // 04000183 RID: 387
            KEY_8,
            // 04000184 RID: 388
            KEY_9,
            // 04000185 RID: 389
            KEY_A = 65,
            // 04000186 RID: 390
            KEY_B,
            // 04000187 RID: 391
            KEY_C,
            // 04000188 RID: 392
            KEY_D,
            // 04000189 RID: 393
            KEY_E,
            // 0400018A RID: 394
            KEY_F,
            // 0400018B RID: 395
            KEY_G,
            // 0400018C RID: 396
            KEY_H,
            // 0400018D RID: 397
            KEY_I,
            // 0400018E RID: 398
            KEY_J,
            // 0400018F RID: 399
            KEY_K,
            // 04000190 RID: 400
            KEY_L,
            // 04000191 RID: 401
            KEY_M,
            // 04000192 RID: 402
            KEY_N,
            // 04000193 RID: 403
            KEY_O,
            // 04000194 RID: 404
            KEY_P,
            // 04000195 RID: 405
            KEY_Q,
            // 04000196 RID: 406
            KEY_R,
            // 04000197 RID: 407
            KEY_S,
            // 04000198 RID: 408
            KEY_T,
            // 04000199 RID: 409
            KEY_U,
            // 0400019A RID: 410
            KEY_V,
            // 0400019B RID: 411
            KEY_W,
            // 0400019C RID: 412
            KEY_X,
            // 0400019D RID: 413
            KEY_Y,
            // 0400019E RID: 414
            KEY_Z,
            // 0400019F RID: 415
            LWIN,
            // 040001A0 RID: 416
            RWIN,
            // 040001A1 RID: 417
            APPS,
            // 040001A2 RID: 418
            SLEEP = 95,
            // 040001A3 RID: 419
            NUMPAD0,
            // 040001A4 RID: 420
            NUMPAD1,
            // 040001A5 RID: 421
            NUMPAD2,
            // 040001A6 RID: 422
            NUMPAD3,
            // 040001A7 RID: 423
            NUMPAD4,
            // 040001A8 RID: 424
            NUMPAD5,
            // 040001A9 RID: 425
            NUMPAD6,
            // 040001AA RID: 426
            NUMPAD7,
            // 040001AB RID: 427
            NUMPAD8,
            // 040001AC RID: 428
            NUMPAD9,
            // 040001AD RID: 429
            MULTIPLY,
            // 040001AE RID: 430
            ADD,
            // 040001AF RID: 431
            SEPARATOR,
            // 040001B0 RID: 432
            SUBTRACT,
            // 040001B1 RID: 433
            DECIMAL,
            // 040001B2 RID: 434
            DIVIDE,
            // 040001B3 RID: 435
            F1,
            // 040001B4 RID: 436
            F2,
            // 040001B5 RID: 437
            F3,
            // 040001B6 RID: 438
            F4,
            // 040001B7 RID: 439
            F5,
            // 040001B8 RID: 440
            F6,
            // 040001B9 RID: 441
            F7,
            // 040001BA RID: 442
            F8,
            // 040001BB RID: 443
            F9,
            // 040001BC RID: 444
            F10,
            // 040001BD RID: 445
            F11,
            // 040001BE RID: 446
            F12,
            // 040001BF RID: 447
            F13,
            // 040001C0 RID: 448
            F14,
            // 040001C1 RID: 449
            F15,
            // 040001C2 RID: 450
            F16,
            // 040001C3 RID: 451
            F17,
            // 040001C4 RID: 452
            F18,
            // 040001C5 RID: 453
            F19,
            // 040001C6 RID: 454
            F20,
            // 040001C7 RID: 455
            F21,
            // 040001C8 RID: 456
            F22,
            // 040001C9 RID: 457
            F23,
            // 040001CA RID: 458
            F24,
            // 040001CB RID: 459
            NUMLOCK = 144,
            // 040001CC RID: 460
            SCROLL,
            // 040001CD RID: 461
            LSHIFT = 160,
            // 040001CE RID: 462
            RSHIFT,
            // 040001CF RID: 463
            LCONTROL,
            // 040001D0 RID: 464
            RCONTROL,
            // 040001D1 RID: 465
            LMENU,
            // 040001D2 RID: 466
            RMENU,
            // 040001D3 RID: 467
            BROWSER_BACK,
            // 040001D4 RID: 468
            BROWSER_FORWARD,
            // 040001D5 RID: 469
            BROWSER_REFRESH,
            // 040001D6 RID: 470
            BROWSER_STOP,
            // 040001D7 RID: 471
            BROWSER_SEARCH,
            // 040001D8 RID: 472
            BROWSER_FAVORITES,
            // 040001D9 RID: 473
            BROWSER_HOME,
            // 040001DA RID: 474
            VOLUME_MUTE,
            // 040001DB RID: 475
            VOLUME_DOWN,
            // 040001DC RID: 476
            VOLUME_UP,
            // 040001DD RID: 477
            MEDIA_NEXT_TRACK,
            // 040001DE RID: 478
            MEDIA_PREV_TRACK,
            // 040001DF RID: 479
            MEDIA_STOP,
            // 040001E0 RID: 480
            MEDIA_PLAY_PAUSE,
            // 040001E1 RID: 481
            LAUNCH_MAIL,
            // 040001E2 RID: 482
            LAUNCH_MEDIA_SELECT,
            // 040001E3 RID: 483
            LAUNCH_APP1,
            // 040001E4 RID: 484
            LAUNCH_APP2,
            // 040001E5 RID: 485
            OEM_1 = 186,
            // 040001E6 RID: 486
            OEM_PLUS,
            // 040001E7 RID: 487
            OEM_COMMA,
            // 040001E8 RID: 488
            OEM_MINUS,
            // 040001E9 RID: 489
            OEM_PERIOD,
            // 040001EA RID: 490
            OEM_2,
            // 040001EB RID: 491
            OEM_3,
            // 040001EC RID: 492
            OEM_4 = 219,
            // 040001ED RID: 493
            OEM_5,
            // 040001EE RID: 494
            OEM_6,
            // 040001EF RID: 495
            OEM_7,
            // 040001F0 RID: 496
            OEM_8,
            // 040001F1 RID: 497
            OEM_102 = 226,
            // 040001F2 RID: 498
            PROCESSKEY = 229,
            // 040001F3 RID: 499
            PACKET = 231,
            // 040001F4 RID: 500
            ATTN = 246,
            // 040001F5 RID: 501
            CRSEL,
            // 040001F6 RID: 502
            EXSEL,
            // 040001F7 RID: 503
            EREOF,
            // 040001F8 RID: 504
            PLAY,
            // 040001F9 RID: 505
            ZOOM,
            // 040001FA RID: 506
            NONAME,
            // 040001FB RID: 507
            PA1,
            // 040001FC RID: 508
            OEM_CLEAR
        }

        public enum BT7 : short
        {
            // 040001FE RID: 510
            LBUTTON,
            // 040001FF RID: 511
            RBUTTON = 0,
            // 04000200 RID: 512
            CANCEL = 70,
            // 04000201 RID: 513
            MBUTTON = 0,
            // 04000202 RID: 514
            XBUTTON1 = 0,
            // 04000203 RID: 515
            XBUTTON2 = 0,
            // 04000204 RID: 516
            BACK = 14,
            // 04000205 RID: 517
            TAB,
            // 04000206 RID: 518
            CLEAR = 76,
            // 04000207 RID: 519
            RETURN = 28,
            // 04000208 RID: 520
            SHIFT = 42,
            // 04000209 RID: 521
            CONTROL = 29,
            // 0400020A RID: 522
            MENU = 56,
            // 0400020B RID: 523
            PAUSE = 0,
            // 0400020C RID: 524
            CAPITAL = 58,
            // 0400020D RID: 525
            KANA = 0,
            // 0400020E RID: 526
            HANGUL = 0,
            // 0400020F RID: 527
            JUNJA = 0,
            // 04000210 RID: 528
            FINAL = 0,
            // 04000211 RID: 529
            HANJA = 0,
            // 04000212 RID: 530
            KANJI = 0,
            // 04000213 RID: 531
            ESCAPE,
            // 04000214 RID: 532
            CONVERT = 0,
            // 04000215 RID: 533
            NONCONVERT = 0,
            // 04000216 RID: 534
            ACCEPT = 0,
            // 04000217 RID: 535
            MODECHANGE = 0,
            // 04000218 RID: 536
            SPACE = 57,
            // 04000219 RID: 537
            PRIOR = 73,
            // 0400021A RID: 538
            NEXT = 81,
            // 0400021B RID: 539
            END = 79,
            // 0400021C RID: 540
            HOME = 71,
            // 0400021D RID: 541
            LEFT = 75,
            // 0400021E RID: 542
            UP = 72,
            // 0400021F RID: 543
            RIGHT = 77,
            // 04000220 RID: 544
            DOWN = 80,
            // 04000221 RID: 545
            SELECT = 0,
            // 04000222 RID: 546
            PRINT = 0,
            // 04000223 RID: 547
            EXECUTE = 0,
            // 04000224 RID: 548
            SNAPSHOT = 84,
            // 04000225 RID: 549
            INSERT = 82,
            // 04000226 RID: 550
            DELETE,
            // 04000227 RID: 551
            HELP = 99,
            // 04000228 RID: 552
            KEY_0 = 11,
            // 04000229 RID: 553
            KEY_1 = 2,
            // 0400022A RID: 554
            KEY_2,
            // 0400022B RID: 555
            KEY_3,
            // 0400022C RID: 556
            KEY_4,
            // 0400022D RID: 557
            KEY_5,
            // 0400022E RID: 558
            KEY_6,
            // 0400022F RID: 559
            KEY_7,
            // 04000230 RID: 560
            KEY_8,
            // 04000231 RID: 561
            KEY_9,
            // 04000232 RID: 562
            KEY_A = 30,
            // 04000233 RID: 563
            KEY_B = 48,
            // 04000234 RID: 564
            KEY_C = 46,
            // 04000235 RID: 565
            KEY_D = 32,
            // 04000236 RID: 566
            KEY_E = 18,
            // 04000237 RID: 567
            KEY_F = 33,
            // 04000238 RID: 568
            KEY_G,
            // 04000239 RID: 569
            KEY_H,
            // 0400023A RID: 570
            KEY_I = 23,
            // 0400023B RID: 571
            KEY_J = 36,
            // 0400023C RID: 572
            KEY_K,
            // 0400023D RID: 573
            KEY_L,
            // 0400023E RID: 574
            KEY_M = 50,
            // 0400023F RID: 575
            KEY_N = 49,
            // 04000240 RID: 576
            KEY_O = 24,
            // 04000241 RID: 577
            KEY_P,
            // 04000242 RID: 578
            KEY_Q = 16,
            // 04000243 RID: 579
            KEY_R = 19,
            // 04000244 RID: 580
            KEY_S = 31,
            // 04000245 RID: 581
            KEY_T = 20,
            // 04000246 RID: 582
            KEY_U = 22,
            // 04000247 RID: 583
            KEY_V = 47,
            // 04000248 RID: 584
            KEY_W = 17,
            // 04000249 RID: 585
            KEY_X = 45,
            // 0400024A RID: 586
            KEY_Y = 21,
            // 0400024B RID: 587
            KEY_Z = 44,
            // 0400024C RID: 588
            LWIN = 91,
            // 0400024D RID: 589
            RWIN,
            // 0400024E RID: 590
            APPS,
            // 0400024F RID: 591
            SLEEP = 95,
            // 04000250 RID: 592
            NUMPAD0 = 82,
            // 04000251 RID: 593
            NUMPAD1 = 79,
            // 04000252 RID: 594
            NUMPAD2,
            // 04000253 RID: 595
            NUMPAD3,
            // 04000254 RID: 596
            NUMPAD4 = 75,
            // 04000255 RID: 597
            NUMPAD5,
            // 04000256 RID: 598
            NUMPAD6,
            // 04000257 RID: 599
            NUMPAD7 = 71,
            // 04000258 RID: 600
            NUMPAD8,
            // 04000259 RID: 601
            NUMPAD9,
            // 0400025A RID: 602
            MULTIPLY = 55,
            // 0400025B RID: 603
            ADD = 78,
            // 0400025C RID: 604
            SEPARATOR = 0,
            // 0400025D RID: 605
            SUBTRACT = 74,
            // 0400025E RID: 606
            DECIMAL = 83,
            // 0400025F RID: 607
            DIVIDE = 53,
            // 04000260 RID: 608
            F1 = 59,
            // 04000261 RID: 609
            F2,
            // 04000262 RID: 610
            F3,
            // 04000263 RID: 611
            F4,
            // 04000264 RID: 612
            F5,
            // 04000265 RID: 613
            F6,
            // 04000266 RID: 614
            F7,
            // 04000267 RID: 615
            F8,
            // 04000268 RID: 616
            F9,
            // 04000269 RID: 617
            F10,
            // 0400026A RID: 618
            F11 = 87,
            // 0400026B RID: 619
            F12,
            // 0400026C RID: 620
            F13 = 100,
            // 0400026D RID: 621
            F14,
            // 0400026E RID: 622
            F15,
            // 0400026F RID: 623
            F16,
            // 04000270 RID: 624
            F17,
            // 04000271 RID: 625
            F18,
            // 04000272 RID: 626
            F19,
            // 04000273 RID: 627
            F20,
            // 04000274 RID: 628
            F21,
            // 04000275 RID: 629
            F22,
            // 04000276 RID: 630
            F23,
            // 04000277 RID: 631
            F24 = 118,
            // 04000278 RID: 632
            NUMLOCK = 69,
            // 04000279 RID: 633
            SCROLL,
            // 0400027A RID: 634
            LSHIFT = 42,
            // 0400027B RID: 635
            RSHIFT = 54,
            // 0400027C RID: 636
            LCONTROL = 29,
            // 0400027D RID: 637
            RCONTROL = 29,
            // 0400027E RID: 638
            LMENU = 56,
            // 0400027F RID: 639
            RMENU = 56,
            // 04000280 RID: 640
            BROWSER_BACK = 106,
            // 04000281 RID: 641
            BROWSER_FORWARD = 105,
            // 04000282 RID: 642
            BROWSER_REFRESH = 103,
            // 04000283 RID: 643
            BROWSER_STOP,
            // 04000284 RID: 644
            BROWSER_SEARCH = 101,
            // 04000285 RID: 645
            BROWSER_FAVORITES,
            // 04000286 RID: 646
            BROWSER_HOME = 50,
            // 04000287 RID: 647
            VOLUME_MUTE = 32,
            // 04000288 RID: 648
            VOLUME_DOWN = 46,
            // 04000289 RID: 649
            VOLUME_UP = 48,
            // 0400028A RID: 650
            MEDIA_NEXT_TRACK = 25,
            // 0400028B RID: 651
            MEDIA_PREV_TRACK = 16,
            // 0400028C RID: 652
            MEDIA_STOP = 36,
            // 0400028D RID: 653
            MEDIA_PLAY_PAUSE = 34,
            // 0400028E RID: 654
            LAUNCH_MAIL = 108,
            // 0400028F RID: 655
            LAUNCH_MEDIA_SELECT,
            // 04000290 RID: 656
            LAUNCH_APP1 = 107,
            // 04000291 RID: 657
            LAUNCH_APP2 = 33,
            // 04000292 RID: 658
            OEM_1 = 39,
            // 04000293 RID: 659
            OEM_PLUS = 13,
            // 04000294 RID: 660
            OEM_COMMA = 51,
            // 04000295 RID: 661
            OEM_MINUS = 12,
            // 04000296 RID: 662
            OEM_PERIOD = 52,
            // 04000297 RID: 663
            OEM_2,
            // 04000298 RID: 664
            OEM_3 = 41,
            // 04000299 RID: 665
            OEM_4 = 26,
            // 0400029A RID: 666
            OEM_5 = 43,
            // 0400029B RID: 667
            OEM_6 = 27,
            // 0400029C RID: 668
            OEM_7 = 40,
            // 0400029D RID: 669
            OEM_8 = 0,
            // 0400029E RID: 670
            OEM_102 = 86,
            // 0400029F RID: 671
            PROCESSKEY = 0,
            // 040002A0 RID: 672
            PACKET = 0,
            // 040002A1 RID: 673
            ATTN = 0,
            // 040002A2 RID: 674
            CRSEL = 0,
            // 040002A3 RID: 675
            EXSEL = 0,
            // 040002A4 RID: 676
            EREOF = 93,
            // 040002A5 RID: 677
            PLAY = 0,
            // 040002A6 RID: 678
            ZOOM = 98,
            // 040002A7 RID: 679
            NONAME = 0,
            // 040002A8 RID: 680
            PA1 = 0,
            // 040002A9 RID: 681
            OEM_CLEAR = 0
        }
    }
}
