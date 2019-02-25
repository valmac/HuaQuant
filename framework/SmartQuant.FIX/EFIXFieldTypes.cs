using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200016A RID: 362
	public sealed class EFIXFieldTypes
	{
		// Token: 0x0600438C RID: 17292 RVA: 0x00049AF4 File Offset: 0x00048AF4
		private EFIXFieldTypes()
		{
		}

		// Token: 0x0600438D RID: 17293 RVA: 0x00049AFC File Offset: 0x00048AFC
		public static FIXType GetFIXType(int tag)
		{
			if (tag <= 10306)
			{
				if (tag <= 10103)
				{
					switch (tag)
					{
					case 1:
						return FIXType.String;
					case 2:
						return FIXType.String;
					case 3:
						return FIXType.String;
					case 4:
						return FIXType.Char;
					case 5:
						return FIXType.String;
					case 6:
						return FIXType.Double;
					case 7:
						return FIXType.Int;
					case 8:
						return FIXType.String;
					case 9:
						return FIXType.Int;
					case 10:
						return FIXType.String;
					case 11:
						return FIXType.String;
					case 12:
						return FIXType.Double;
					case 13:
						return FIXType.Char;
					case 14:
						return FIXType.Double;
					case 15:
						return FIXType.String;
					case 16:
						return FIXType.Int;
					case 17:
						return FIXType.String;
					case 18:
						return FIXType.String;
					case 19:
						return FIXType.String;
					case 20:
						return FIXType.Char;
					case 21:
						return FIXType.Char;
					case 22:
						return FIXType.String;
					case 23:
						return FIXType.String;
					case 24:
						return FIXType.Char;
					case 25:
						return FIXType.Char;
					case 26:
						return FIXType.String;
					case 27:
						return FIXType.String;
					case 28:
						return FIXType.Char;
					case 29:
						return FIXType.Char;
					case 30:
						return FIXType.String;
					case 31:
						return FIXType.Double;
					case 32:
						return FIXType.Double;
					case 33:
						return FIXType.Int;
					case 34:
						return FIXType.Int;
					case 35:
						return FIXType.String;
					case 36:
						return FIXType.Int;
					case 37:
						return FIXType.String;
					case 38:
						return FIXType.Double;
					case 39:
						return FIXType.Char;
					case 40:
						return FIXType.Char;
					case 41:
						return FIXType.String;
					case 42:
						return FIXType.DateTime;
					case 43:
						return FIXType.Bool;
					case 44:
						return FIXType.Double;
					case 45:
						return FIXType.Int;
					case 46:
						return FIXType.String;
					case 47:
						return FIXType.Char;
					case 48:
						return FIXType.String;
					case 49:
						return FIXType.String;
					case 50:
						return FIXType.String;
					case 51:
						return FIXType.DateTime;
					case 52:
						return FIXType.DateTime;
					case 53:
						return FIXType.Double;
					case 54:
						return FIXType.Char;
					case 55:
						return FIXType.String;
					case 56:
						return FIXType.String;
					case 57:
						return FIXType.String;
					case 58:
						return FIXType.String;
					case 59:
						return FIXType.Char;
					case 60:
						return FIXType.DateTime;
					case 61:
						return FIXType.Char;
					case 62:
						return FIXType.DateTime;
					case 63:
						return FIXType.Char;
					case 64:
						return FIXType.DateTime;
					case 65:
						return FIXType.String;
					case 66:
						return FIXType.String;
					case 67:
						return FIXType.Int;
					case 68:
						return FIXType.Int;
					case 69:
						return FIXType.String;
					case 70:
						return FIXType.String;
					case 71:
						return FIXType.Char;
					case 72:
						return FIXType.String;
					case 73:
						return FIXType.Int;
					case 74:
						return FIXType.Int;
					case 75:
						return FIXType.DateTime;
					case 76:
						return FIXType.String;
					case 77:
						return FIXType.Char;
					case 78:
						return FIXType.Int;
					case 79:
						return FIXType.String;
					case 80:
						return FIXType.Double;
					case 81:
						return FIXType.Char;
					case 82:
						return FIXType.Int;
					case 83:
						return FIXType.Int;
					case 84:
						return FIXType.Double;
					case 85:
						return FIXType.Int;
					case 86:
						return FIXType.String;
					case 87:
						return FIXType.Int;
					case 88:
						return FIXType.Int;
					case 89:
						return FIXType.String;
					case 90:
						return FIXType.Int;
					case 91:
						return FIXType.String;
					case 92:
						return FIXType.String;
					case 93:
						return FIXType.Int;
					case 94:
						return FIXType.Char;
					case 95:
						return FIXType.Int;
					case 96:
						return FIXType.String;
					case 97:
						return FIXType.Bool;
					case 98:
						return FIXType.Int;
					case 99:
						return FIXType.Double;
					case 100:
						return FIXType.String;
					case 101:
					case 261:
					case 809:
						break;
					case 102:
						return FIXType.Int;
					case 103:
						return FIXType.Int;
					case 104:
						return FIXType.Char;
					case 105:
						return FIXType.String;
					case 106:
						return FIXType.String;
					case 107:
						return FIXType.String;
					case 108:
						return FIXType.Int;
					case 109:
						return FIXType.String;
					case 110:
						return FIXType.Double;
					case 111:
						return FIXType.Double;
					case 112:
						return FIXType.String;
					case 113:
						return FIXType.Bool;
					case 114:
						return FIXType.Bool;
					case 115:
						return FIXType.String;
					case 116:
						return FIXType.String;
					case 117:
						return FIXType.String;
					case 118:
						return FIXType.Double;
					case 119:
						return FIXType.Double;
					case 120:
						return FIXType.Double;
					case 121:
						return FIXType.Bool;
					case 122:
						return FIXType.DateTime;
					case 123:
						return FIXType.Bool;
					case 124:
						return FIXType.Int;
					case 125:
						return FIXType.Char;
					case 126:
						return FIXType.DateTime;
					case 127:
						return FIXType.Char;
					case 128:
						return FIXType.String;
					case 129:
						return FIXType.String;
					case 130:
						return FIXType.Bool;
					case 131:
						return FIXType.String;
					case 132:
						return FIXType.Double;
					case 133:
						return FIXType.Double;
					case 134:
						return FIXType.Double;
					case 135:
						return FIXType.Double;
					case 136:
						return FIXType.Int;
					case 137:
						return FIXType.Double;
					case 138:
						return FIXType.Double;
					case 139:
						return FIXType.Char;
					case 140:
						return FIXType.Double;
					case 141:
						return FIXType.Bool;
					case 142:
						return FIXType.String;
					case 143:
						return FIXType.String;
					case 144:
						return FIXType.String;
					case 145:
						return FIXType.String;
					case 146:
						return FIXType.Int;
					case 147:
						return FIXType.String;
					case 148:
						return FIXType.String;
					case 149:
						return FIXType.String;
					case 150:
						return FIXType.Char;
					case 151:
						return FIXType.Double;
					case 152:
						return FIXType.Double;
					case 153:
						return FIXType.Double;
					case 154:
						return FIXType.Double;
					case 155:
						return FIXType.Double;
					case 156:
						return FIXType.Char;
					case 157:
						return FIXType.Int;
					case 158:
						return FIXType.Double;
					case 159:
						return FIXType.Double;
					case 160:
						return FIXType.Char;
					case 161:
						return FIXType.String;
					case 162:
						return FIXType.String;
					case 163:
						return FIXType.Char;
					case 164:
						return FIXType.String;
					case 165:
						return FIXType.Char;
					case 166:
						return FIXType.String;
					case 167:
						return FIXType.String;
					case 168:
						return FIXType.DateTime;
					case 169:
						return FIXType.Int;
					case 170:
						return FIXType.String;
					case 171:
						return FIXType.String;
					case 172:
						return FIXType.Int;
					case 173:
						return FIXType.String;
					case 174:
						return FIXType.String;
					case 175:
						return FIXType.String;
					case 176:
						return FIXType.String;
					case 177:
						return FIXType.String;
					case 178:
						return FIXType.String;
					case 179:
						return FIXType.String;
					case 180:
						return FIXType.String;
					case 181:
						return FIXType.String;
					case 182:
						return FIXType.String;
					case 183:
						return FIXType.String;
					case 184:
						return FIXType.String;
					case 185:
						return FIXType.String;
					case 186:
						return FIXType.String;
					case 187:
						return FIXType.String;
					case 188:
						return FIXType.Double;
					case 189:
						return FIXType.Double;
					case 190:
						return FIXType.Double;
					case 191:
						return FIXType.Double;
					case 192:
						return FIXType.Double;
					case 193:
						return FIXType.DateTime;
					case 194:
						return FIXType.Double;
					case 195:
						return FIXType.Double;
					case 196:
						return FIXType.String;
					case 197:
						return FIXType.Int;
					case 198:
						return FIXType.String;
					case 199:
						return FIXType.Int;
					case 200:
						return FIXType.String;
					case 201:
						return FIXType.Int;
					case 202:
						return FIXType.Double;
					case 203:
						return FIXType.Int;
					case 204:
						return FIXType.Int;
					case 205:
						return FIXType.String;
					case 206:
						return FIXType.Char;
					case 207:
						return FIXType.String;
					case 208:
						return FIXType.Bool;
					case 209:
						return FIXType.Int;
					case 210:
						return FIXType.Double;
					case 211:
						return FIXType.Double;
					case 212:
						return FIXType.Int;
					case 213:
						return FIXType.String;
					case 214:
						return FIXType.String;
					case 215:
						return FIXType.Int;
					case 216:
						return FIXType.Int;
					case 217:
						return FIXType.String;
					case 218:
						return FIXType.Double;
					case 219:
						return FIXType.Char;
					case 220:
						return FIXType.Double;
					case 221:
						return FIXType.String;
					case 222:
						return FIXType.String;
					case 223:
						return FIXType.Double;
					case 224:
						return FIXType.DateTime;
					case 225:
						return FIXType.DateTime;
					case 226:
						return FIXType.Int;
					case 227:
						return FIXType.Double;
					case 228:
						return FIXType.Double;
					case 229:
						return FIXType.DateTime;
					case 230:
						return FIXType.DateTime;
					case 231:
						return FIXType.Double;
					case 232:
						return FIXType.Int;
					case 233:
						return FIXType.String;
					case 234:
						return FIXType.String;
					case 235:
						return FIXType.String;
					case 236:
						return FIXType.Double;
					case 237:
						return FIXType.Double;
					case 238:
						return FIXType.Double;
					case 239:
						return FIXType.Int;
					case 240:
						return FIXType.DateTime;
					case 241:
						return FIXType.DateTime;
					case 242:
						return FIXType.DateTime;
					case 243:
						return FIXType.Int;
					case 244:
						return FIXType.Int;
					case 245:
						return FIXType.Double;
					case 246:
						return FIXType.Double;
					case 247:
						return FIXType.DateTime;
					case 248:
						return FIXType.DateTime;
					case 249:
						return FIXType.DateTime;
					case 250:
						return FIXType.Int;
					case 251:
						return FIXType.Int;
					case 252:
						return FIXType.Double;
					case 253:
						return FIXType.Double;
					case 254:
						return FIXType.DateTime;
					case 255:
						return FIXType.String;
					case 256:
						return FIXType.String;
					case 257:
						return FIXType.String;
					case 258:
						return FIXType.Bool;
					case 259:
						return FIXType.DateTime;
					case 260:
						return FIXType.Double;
					case 262:
						return FIXType.String;
					case 263:
						return FIXType.Char;
					case 264:
						return FIXType.Int;
					case 265:
						return FIXType.Int;
					case 266:
						return FIXType.Char;
					case 267:
						return FIXType.Int;
					case 268:
						return FIXType.Int;
					case 269:
						return FIXType.Char;
					case 270:
						return FIXType.Double;
					case 271:
						return FIXType.Double;
					case 272:
						return FIXType.DateTime;
					case 273:
						return FIXType.DateTime;
					case 274:
						return FIXType.Char;
					case 275:
						return FIXType.String;
					case 276:
						return FIXType.String;
					case 277:
						return FIXType.String;
					case 278:
						return FIXType.String;
					case 279:
						return FIXType.Char;
					case 280:
						return FIXType.String;
					case 281:
						return FIXType.Char;
					case 282:
						return FIXType.String;
					case 283:
						return FIXType.String;
					case 284:
						return FIXType.String;
					case 285:
						return FIXType.Char;
					case 286:
						return FIXType.String;
					case 287:
						return FIXType.Int;
					case 288:
						return FIXType.String;
					case 289:
						return FIXType.String;
					case 290:
						return FIXType.Int;
					case 291:
						return FIXType.String;
					case 292:
						return FIXType.String;
					case 293:
						return FIXType.Double;
					case 294:
						return FIXType.Double;
					case 295:
						return FIXType.Int;
					case 296:
						return FIXType.Int;
					case 297:
						return FIXType.Int;
					case 298:
						return FIXType.Int;
					case 299:
						return FIXType.String;
					case 300:
						return FIXType.Int;
					case 301:
						return FIXType.Int;
					case 302:
						return FIXType.String;
					case 303:
						return FIXType.Int;
					case 304:
						return FIXType.Int;
					case 305:
						return FIXType.String;
					case 306:
						return FIXType.String;
					case 307:
						return FIXType.String;
					case 308:
						return FIXType.String;
					case 309:
						return FIXType.String;
					case 310:
						return FIXType.String;
					case 311:
						return FIXType.String;
					case 312:
						return FIXType.String;
					case 313:
						return FIXType.String;
					case 314:
						return FIXType.DateTime;
					case 315:
						return FIXType.Int;
					case 316:
						return FIXType.Double;
					case 317:
						return FIXType.Char;
					case 318:
						return FIXType.Double;
					case 319:
						return FIXType.Double;
					case 320:
						return FIXType.String;
					case 321:
						return FIXType.Int;
					case 322:
						return FIXType.String;
					case 323:
						return FIXType.Int;
					case 324:
						return FIXType.String;
					case 325:
						return FIXType.Bool;
					case 326:
						return FIXType.Int;
					case 327:
						return FIXType.Char;
					case 328:
						return FIXType.Bool;
					case 329:
						return FIXType.Bool;
					case 330:
						return FIXType.Double;
					case 331:
						return FIXType.Double;
					case 332:
						return FIXType.Double;
					case 333:
						return FIXType.Double;
					case 334:
						return FIXType.Int;
					case 335:
						return FIXType.String;
					case 336:
						return FIXType.String;
					case 337:
						return FIXType.String;
					case 338:
						return FIXType.Int;
					case 339:
						return FIXType.Int;
					case 340:
						return FIXType.Int;
					case 341:
						return FIXType.DateTime;
					case 342:
						return FIXType.DateTime;
					case 343:
						return FIXType.DateTime;
					case 344:
						return FIXType.DateTime;
					case 345:
						return FIXType.DateTime;
					case 346:
						return FIXType.Int;
					case 347:
						return FIXType.String;
					case 348:
						return FIXType.Int;
					case 349:
						return FIXType.String;
					case 350:
						return FIXType.Int;
					case 351:
						return FIXType.String;
					case 352:
						return FIXType.Int;
					case 353:
						return FIXType.String;
					case 354:
						return FIXType.Int;
					case 355:
						return FIXType.String;
					case 356:
						return FIXType.Int;
					case 357:
						return FIXType.String;
					case 358:
						return FIXType.Int;
					case 359:
						return FIXType.String;
					case 360:
						return FIXType.Int;
					case 361:
						return FIXType.String;
					case 362:
						return FIXType.Int;
					case 363:
						return FIXType.String;
					case 364:
						return FIXType.Int;
					case 365:
						return FIXType.String;
					case 366:
						return FIXType.Double;
					case 367:
						return FIXType.DateTime;
					case 368:
						return FIXType.Int;
					case 369:
						return FIXType.Int;
					case 370:
						return FIXType.DateTime;
					case 371:
						return FIXType.Int;
					case 372:
						return FIXType.String;
					case 373:
						return FIXType.Int;
					case 374:
						return FIXType.Char;
					case 375:
						return FIXType.String;
					case 376:
						return FIXType.String;
					case 377:
						return FIXType.Bool;
					case 378:
						return FIXType.Int;
					case 379:
						return FIXType.String;
					case 380:
						return FIXType.Int;
					case 381:
						return FIXType.Double;
					case 382:
						return FIXType.Int;
					case 383:
						return FIXType.Int;
					case 384:
						return FIXType.Int;
					case 385:
						return FIXType.Char;
					case 386:
						return FIXType.Int;
					case 387:
						return FIXType.Double;
					case 388:
						return FIXType.Char;
					case 389:
						return FIXType.Double;
					case 390:
						return FIXType.String;
					case 391:
						return FIXType.String;
					case 392:
						return FIXType.String;
					case 393:
						return FIXType.Int;
					case 394:
						return FIXType.Int;
					case 395:
						return FIXType.Int;
					case 396:
						return FIXType.Double;
					case 397:
						return FIXType.Double;
					case 398:
						return FIXType.Int;
					case 399:
						return FIXType.Int;
					case 400:
						return FIXType.String;
					case 401:
						return FIXType.Int;
					case 402:
						return FIXType.Double;
					case 403:
						return FIXType.Double;
					case 404:
						return FIXType.Double;
					case 405:
						return FIXType.Double;
					case 406:
						return FIXType.Double;
					case 407:
						return FIXType.Double;
					case 408:
						return FIXType.Double;
					case 409:
						return FIXType.Int;
					case 410:
						return FIXType.Double;
					case 411:
						return FIXType.Bool;
					case 412:
						return FIXType.Double;
					case 413:
						return FIXType.Double;
					case 414:
						return FIXType.Int;
					case 415:
						return FIXType.Int;
					case 416:
						return FIXType.Int;
					case 417:
						return FIXType.Int;
					case 418:
						return FIXType.Char;
					case 419:
						return FIXType.Char;
					case 420:
						return FIXType.Int;
					case 421:
						return FIXType.String;
					case 422:
						return FIXType.Int;
					case 423:
						return FIXType.Int;
					case 424:
						return FIXType.Double;
					case 425:
						return FIXType.Double;
					case 426:
						return FIXType.Double;
					case 427:
						return FIXType.Int;
					case 428:
						return FIXType.Int;
					case 429:
						return FIXType.Int;
					case 430:
						return FIXType.Int;
					case 431:
						return FIXType.Int;
					case 432:
						return FIXType.DateTime;
					case 433:
						return FIXType.Char;
					case 434:
						return FIXType.Char;
					case 435:
						return FIXType.Double;
					case 436:
						return FIXType.Double;
					case 437:
						return FIXType.Double;
					case 438:
						return FIXType.DateTime;
					case 439:
						return FIXType.String;
					case 440:
						return FIXType.String;
					case 441:
						return FIXType.Int;
					case 442:
						return FIXType.Char;
					case 443:
						return FIXType.DateTime;
					case 444:
						return FIXType.String;
					case 445:
						return FIXType.Int;
					case 446:
						return FIXType.String;
					case 447:
						return FIXType.Char;
					case 448:
						return FIXType.String;
					case 449:
						return FIXType.DateTime;
					case 450:
						return FIXType.DateTime;
					case 451:
						return FIXType.Double;
					case 452:
						return FIXType.Int;
					case 453:
						return FIXType.Int;
					case 454:
						return FIXType.Int;
					case 455:
						return FIXType.String;
					case 456:
						return FIXType.String;
					case 457:
						return FIXType.Int;
					case 458:
						return FIXType.String;
					case 459:
						return FIXType.String;
					case 460:
						return FIXType.Int;
					case 461:
						return FIXType.String;
					case 462:
						return FIXType.Int;
					case 463:
						return FIXType.String;
					case 464:
						return FIXType.Bool;
					case 465:
						return FIXType.Int;
					case 466:
						return FIXType.String;
					case 467:
						return FIXType.String;
					case 468:
						return FIXType.Char;
					case 469:
						return FIXType.Double;
					case 470:
						return FIXType.String;
					case 471:
						return FIXType.String;
					case 472:
						return FIXType.String;
					case 473:
						return FIXType.Int;
					case 474:
						return FIXType.String;
					case 475:
						return FIXType.String;
					case 476:
						return FIXType.String;
					case 477:
						return FIXType.Int;
					case 478:
						return FIXType.Double;
					case 479:
						return FIXType.Double;
					case 480:
						return FIXType.Char;
					case 481:
						return FIXType.Char;
					case 482:
						return FIXType.String;
					case 483:
						return FIXType.DateTime;
					case 484:
						return FIXType.Char;
					case 485:
						return FIXType.Double;
					case 486:
						return FIXType.DateTime;
					case 487:
						return FIXType.Int;
					case 488:
						return FIXType.String;
					case 489:
						return FIXType.String;
					case 490:
						return FIXType.DateTime;
					case 491:
						return FIXType.String;
					case 492:
						return FIXType.Int;
					case 493:
						return FIXType.String;
					case 494:
						return FIXType.String;
					case 495:
						return FIXType.Int;
					case 496:
						return FIXType.String;
					case 497:
						return FIXType.Char;
					case 498:
						return FIXType.String;
					case 499:
						return FIXType.String;
					case 500:
						return FIXType.String;
					case 501:
						return FIXType.String;
					case 502:
						return FIXType.String;
					case 503:
						return FIXType.DateTime;
					case 504:
						return FIXType.DateTime;
					case 505:
						return FIXType.String;
					case 506:
						return FIXType.Char;
					case 507:
						return FIXType.Int;
					case 508:
						return FIXType.String;
					case 509:
						return FIXType.String;
					case 510:
						return FIXType.Int;
					case 511:
						return FIXType.String;
					case 512:
						return FIXType.Double;
					case 513:
						return FIXType.String;
					case 514:
						return FIXType.Char;
					case 515:
						return FIXType.DateTime;
					case 516:
						return FIXType.Double;
					case 517:
						return FIXType.Char;
					case 518:
						return FIXType.Int;
					case 519:
						return FIXType.Int;
					case 520:
						return FIXType.Double;
					case 521:
						return FIXType.Double;
					case 522:
						return FIXType.Int;
					case 523:
						return FIXType.String;
					case 524:
						return FIXType.String;
					case 525:
						return FIXType.Char;
					case 526:
						return FIXType.String;
					case 527:
						return FIXType.String;
					case 528:
						return FIXType.Char;
					case 529:
						return FIXType.String;
					case 530:
						return FIXType.Char;
					case 531:
						return FIXType.Char;
					case 532:
						return FIXType.Char;
					case 533:
						return FIXType.Int;
					case 534:
						return FIXType.Int;
					case 535:
						return FIXType.String;
					case 536:
						return FIXType.String;
					case 537:
						return FIXType.Int;
					case 538:
						return FIXType.Int;
					case 539:
						return FIXType.Int;
					case 540:
						return FIXType.Double;
					case 541:
						return FIXType.DateTime;
					case 542:
						return FIXType.DateTime;
					case 543:
						return FIXType.String;
					case 544:
						return FIXType.Char;
					case 545:
						return FIXType.String;
					case 546:
						return FIXType.String;
					case 547:
						return FIXType.Bool;
					case 548:
						return FIXType.String;
					case 549:
						return FIXType.Int;
					case 550:
						return FIXType.Int;
					case 551:
						return FIXType.String;
					case 552:
						return FIXType.Int;
					case 553:
						return FIXType.String;
					case 554:
						return FIXType.String;
					case 555:
						return FIXType.Int;
					case 556:
						return FIXType.Double;
					case 557:
						return FIXType.Int;
					case 558:
						return FIXType.Int;
					case 559:
						return FIXType.Int;
					case 560:
						return FIXType.Int;
					case 561:
						return FIXType.Double;
					case 562:
						return FIXType.Double;
					case 563:
						return FIXType.Int;
					case 564:
						return FIXType.Char;
					case 565:
						return FIXType.Int;
					case 566:
						return FIXType.Double;
					case 567:
						return FIXType.Int;
					case 568:
						return FIXType.String;
					case 569:
						return FIXType.Int;
					case 570:
						return FIXType.Bool;
					case 571:
						return FIXType.String;
					case 572:
						return FIXType.String;
					case 573:
						return FIXType.Char;
					case 574:
						return FIXType.String;
					case 575:
						return FIXType.Bool;
					case 576:
						return FIXType.Int;
					case 577:
						return FIXType.Int;
					case 578:
						return FIXType.String;
					case 579:
						return FIXType.String;
					case 580:
						return FIXType.Int;
					case 581:
						return FIXType.Int;
					case 582:
						return FIXType.Int;
					case 583:
						return FIXType.String;
					case 584:
						return FIXType.String;
					case 585:
						return FIXType.Int;
					case 586:
						return FIXType.DateTime;
					case 587:
						return FIXType.Char;
					case 588:
						return FIXType.DateTime;
					case 589:
						return FIXType.Char;
					case 590:
						return FIXType.Char;
					case 591:
						return FIXType.Char;
					case 592:
						return FIXType.String;
					case 593:
						return FIXType.String;
					case 594:
						return FIXType.String;
					case 595:
						return FIXType.String;
					case 596:
						return FIXType.String;
					case 597:
						return FIXType.String;
					case 598:
						return FIXType.String;
					case 599:
						return FIXType.String;
					case 600:
						return FIXType.String;
					case 601:
						return FIXType.String;
					case 602:
						return FIXType.String;
					case 603:
						return FIXType.String;
					case 604:
						return FIXType.String;
					case 605:
						return FIXType.String;
					case 606:
						return FIXType.String;
					case 607:
						return FIXType.Int;
					case 608:
						return FIXType.String;
					case 609:
						return FIXType.String;
					case 610:
						return FIXType.String;
					case 611:
						return FIXType.DateTime;
					case 612:
						return FIXType.Double;
					case 613:
						return FIXType.Char;
					case 614:
						return FIXType.Double;
					case 615:
						return FIXType.Double;
					case 616:
						return FIXType.String;
					case 617:
						return FIXType.String;
					case 618:
						return FIXType.Int;
					case 619:
						return FIXType.String;
					case 620:
						return FIXType.String;
					case 621:
						return FIXType.Int;
					case 622:
						return FIXType.String;
					case 623:
						return FIXType.Double;
					case 624:
						return FIXType.Char;
					case 625:
						return FIXType.String;
					case 626:
						return FIXType.Int;
					case 627:
						return FIXType.Int;
					case 628:
						return FIXType.String;
					case 629:
						return FIXType.DateTime;
					case 630:
						return FIXType.Int;
					case 631:
						return FIXType.Double;
					case 632:
						return FIXType.Double;
					case 633:
						return FIXType.Double;
					case 634:
						return FIXType.Double;
					case 635:
						return FIXType.String;
					case 636:
						return FIXType.Bool;
					case 637:
						return FIXType.Double;
					case 638:
						return FIXType.Int;
					case 639:
						return FIXType.Double;
					case 640:
						return FIXType.Double;
					case 641:
						return FIXType.Double;
					case 642:
						return FIXType.Double;
					case 643:
						return FIXType.Double;
					case 644:
						return FIXType.String;
					case 645:
						return FIXType.Double;
					case 646:
						return FIXType.Double;
					case 647:
						return FIXType.Double;
					case 648:
						return FIXType.Double;
					case 649:
						return FIXType.String;
					case 650:
						return FIXType.Bool;
					case 651:
						return FIXType.Double;
					case 652:
						return FIXType.Double;
					case 653:
						return FIXType.Int;
					case 654:
						return FIXType.String;
					case 655:
						return FIXType.String;
					case 656:
						return FIXType.Double;
					case 657:
						return FIXType.Double;
					case 658:
						return FIXType.Int;
					case 659:
						return FIXType.String;
					case 660:
						return FIXType.Int;
					case 661:
						return FIXType.Int;
					case 662:
						return FIXType.Double;
					case 663:
						return FIXType.Int;
					case 664:
						return FIXType.String;
					case 665:
						return FIXType.Int;
					case 666:
						return FIXType.Int;
					case 667:
						return FIXType.String;
					case 668:
						return FIXType.Int;
					case 669:
						return FIXType.Double;
					case 670:
						return FIXType.Int;
					case 671:
						return FIXType.String;
					case 672:
						return FIXType.String;
					case 673:
						return FIXType.Double;
					case 674:
						return FIXType.String;
					case 675:
						return FIXType.Double;
					case 676:
						return FIXType.Double;
					case 677:
						return FIXType.String;
					case 678:
						return FIXType.String;
					case 679:
						return FIXType.Double;
					case 680:
						return FIXType.Int;
					case 681:
						return FIXType.Double;
					case 682:
						return FIXType.String;
					case 683:
						return FIXType.Int;
					case 684:
						return FIXType.Double;
					case 685:
						return FIXType.Double;
					case 686:
						return FIXType.Int;
					case 687:
						return FIXType.Double;
					case 688:
						return FIXType.String;
					case 689:
						return FIXType.String;
					case 690:
						return FIXType.Int;
					case 691:
						return FIXType.String;
					case 692:
						return FIXType.Int;
					case 693:
						return FIXType.String;
					case 694:
						return FIXType.Int;
					case 695:
						return FIXType.Char;
					case 696:
						return FIXType.DateTime;
					case 697:
						return FIXType.Double;
					case 698:
						return FIXType.Int;
					case 699:
						return FIXType.String;
					case 700:
						return FIXType.Bool;
					case 701:
						return FIXType.DateTime;
					case 702:
						return FIXType.Int;
					case 703:
						return FIXType.String;
					case 704:
						return FIXType.Double;
					case 705:
						return FIXType.Double;
					case 706:
						return FIXType.Int;
					case 707:
						return FIXType.String;
					case 708:
						return FIXType.Double;
					case 709:
						return FIXType.Int;
					case 710:
						return FIXType.String;
					case 711:
						return FIXType.Int;
					case 712:
						return FIXType.Int;
					case 713:
						return FIXType.String;
					case 714:
						return FIXType.String;
					case 715:
						return FIXType.DateTime;
					case 716:
						return FIXType.String;
					case 717:
						return FIXType.String;
					case 718:
						return FIXType.Int;
					case 719:
						return FIXType.Bool;
					case 720:
						return FIXType.Bool;
					case 721:
						return FIXType.String;
					case 722:
						return FIXType.Int;
					case 723:
						return FIXType.Int;
					case 724:
						return FIXType.Int;
					case 725:
						return FIXType.Int;
					case 726:
						return FIXType.String;
					case 727:
						return FIXType.Int;
					case 728:
						return FIXType.Int;
					case 729:
						return FIXType.Int;
					case 730:
						return FIXType.Double;
					case 731:
						return FIXType.Int;
					case 732:
						return FIXType.Double;
					case 733:
						return FIXType.Int;
					case 734:
						return FIXType.Double;
					case 735:
						return FIXType.Int;
					case 736:
						return FIXType.Double;
					case 737:
						return FIXType.Double;
					case 738:
						return FIXType.Double;
					case 739:
						return FIXType.DateTime;
					case 740:
						return FIXType.String;
					case 741:
						return FIXType.Double;
					case 742:
						return FIXType.Double;
					case 743:
						return FIXType.DateTime;
					case 744:
						return FIXType.Char;
					case 745:
						return FIXType.Double;
					case 746:
						return FIXType.Double;
					case 747:
						return FIXType.Char;
					case 748:
						return FIXType.Int;
					case 749:
						return FIXType.Int;
					case 750:
						return FIXType.Int;
					case 751:
						return FIXType.Int;
					case 752:
						return FIXType.Int;
					case 753:
						return FIXType.Int;
					case 754:
						return FIXType.Bool;
					case 755:
						return FIXType.String;
					case 756:
						return FIXType.Int;
					case 757:
						return FIXType.String;
					case 758:
						return FIXType.Char;
					case 759:
						return FIXType.Int;
					case 760:
						return FIXType.String;
					case 761:
						return FIXType.String;
					case 762:
						return FIXType.String;
					case 763:
						return FIXType.String;
					case 764:
						return FIXType.String;
					case 765:
						return FIXType.Double;
					case 766:
						return FIXType.Double;
					case 767:
						return FIXType.Double;
					case 768:
						return FIXType.Int;
					case 769:
						return FIXType.DateTime;
					case 770:
						return FIXType.Int;
					case 771:
						return FIXType.String;
					case 772:
						return FIXType.String;
					case 773:
						return FIXType.Int;
					case 774:
						return FIXType.Int;
					case 775:
						return FIXType.Int;
					case 776:
						return FIXType.Int;
					case 777:
						return FIXType.String;
					case 778:
						return FIXType.Int;
					case 779:
						return FIXType.DateTime;
					case 780:
						return FIXType.Int;
					case 781:
						return FIXType.Int;
					case 782:
						return FIXType.String;
					case 783:
						return FIXType.Char;
					case 784:
						return FIXType.Int;
					case 785:
						return FIXType.String;
					case 786:
						return FIXType.Int;
					case 787:
						return FIXType.Char;
					case 788:
						return FIXType.Int;
					case 789:
						return FIXType.Int;
					case 790:
						return FIXType.String;
					case 791:
						return FIXType.String;
					case 792:
						return FIXType.Int;
					case 793:
						return FIXType.String;
					case 794:
						return FIXType.Int;
					case 795:
						return FIXType.String;
					case 796:
						return FIXType.Int;
					case 797:
						return FIXType.Bool;
					case 798:
						return FIXType.Int;
					case 799:
						return FIXType.Double;
					case 800:
						return FIXType.Double;
					case 801:
						return FIXType.Int;
					case 802:
						return FIXType.Int;
					case 803:
						return FIXType.Int;
					case 804:
						return FIXType.Int;
					case 805:
						return FIXType.Int;
					case 806:
						return FIXType.Int;
					case 807:
						return FIXType.Int;
					case 808:
						return FIXType.Int;
					case 810:
						return FIXType.Double;
					case 811:
						return FIXType.Double;
					case 812:
						return FIXType.Int;
					case 813:
						return FIXType.Int;
					case 814:
						return FIXType.Int;
					case 815:
						return FIXType.Int;
					case 816:
						return FIXType.Int;
					case 817:
						return FIXType.String;
					case 818:
						return FIXType.String;
					case 819:
						return FIXType.Int;
					case 820:
						return FIXType.String;
					case 821:
						return FIXType.String;
					case 822:
						return FIXType.String;
					case 823:
						return FIXType.String;
					case 824:
						return FIXType.String;
					case 825:
						return FIXType.String;
					case 826:
						return FIXType.Int;
					case 827:
						return FIXType.Int;
					case 828:
						return FIXType.Int;
					case 829:
						return FIXType.Int;
					case 830:
						return FIXType.String;
					case 831:
						return FIXType.String;
					case 832:
						return FIXType.Int;
					case 833:
						return FIXType.String;
					case 834:
						return FIXType.Double;
					case 835:
						return FIXType.Int;
					case 836:
						return FIXType.Int;
					case 837:
						return FIXType.Int;
					case 838:
						return FIXType.Int;
					case 839:
						return FIXType.Double;
					case 840:
						return FIXType.Int;
					case 841:
						return FIXType.Int;
					case 842:
						return FIXType.Int;
					case 843:
						return FIXType.Int;
					case 844:
						return FIXType.Int;
					case 845:
						return FIXType.Double;
					case 846:
						return FIXType.Int;
					case 847:
						return FIXType.Int;
					case 848:
						return FIXType.String;
					case 849:
						return FIXType.Double;
					case 850:
						return FIXType.Double;
					case 851:
						return FIXType.Int;
					case 852:
						return FIXType.Bool;
					case 853:
						return FIXType.Int;
					case 854:
						return FIXType.Int;
					case 855:
						return FIXType.Int;
					case 856:
						return FIXType.Int;
					case 857:
						return FIXType.Int;
					case 858:
						return FIXType.Double;
					case 859:
						return FIXType.String;
					case 860:
						return FIXType.Double;
					case 861:
						return FIXType.Double;
					case 862:
						return FIXType.Int;
					case 863:
						return FIXType.Double;
					case 864:
						return FIXType.Int;
					case 865:
						return FIXType.Int;
					case 866:
						return FIXType.DateTime;
					case 867:
						return FIXType.Double;
					case 868:
						return FIXType.String;
					case 869:
						return FIXType.Double;
					case 870:
						return FIXType.Int;
					case 871:
						return FIXType.Int;
					case 872:
						return FIXType.String;
					case 873:
						return FIXType.DateTime;
					case 874:
						return FIXType.DateTime;
					case 875:
						return FIXType.Int;
					case 876:
						return FIXType.String;
					case 877:
						return FIXType.String;
					case 878:
						return FIXType.String;
					case 879:
						return FIXType.Double;
					case 880:
						return FIXType.String;
					case 881:
						return FIXType.String;
					case 882:
						return FIXType.Double;
					case 883:
						return FIXType.Double;
					case 884:
						return FIXType.Double;
					case 885:
						return FIXType.Double;
					case 886:
						return FIXType.Double;
					case 887:
						return FIXType.Int;
					case 888:
						return FIXType.String;
					case 889:
						return FIXType.String;
					case 890:
						return FIXType.Double;
					case 891:
						return FIXType.Int;
					case 892:
						return FIXType.Int;
					case 893:
						return FIXType.Bool;
					case 894:
						return FIXType.String;
					case 895:
						return FIXType.Int;
					case 896:
						return FIXType.Int;
					case 897:
						return FIXType.Int;
					case 898:
						return FIXType.Double;
					case 899:
						return FIXType.Double;
					case 900:
						return FIXType.Double;
					case 901:
						return FIXType.Double;
					case 902:
						return FIXType.String;
					case 903:
						return FIXType.Int;
					case 904:
						return FIXType.String;
					case 905:
						return FIXType.Int;
					case 906:
						return FIXType.Int;
					case 907:
						return FIXType.String;
					case 908:
						return FIXType.String;
					case 909:
						return FIXType.String;
					case 910:
						return FIXType.Int;
					case 911:
						return FIXType.Int;
					case 912:
						return FIXType.Bool;
					case 913:
						return FIXType.String;
					case 914:
						return FIXType.String;
					case 915:
						return FIXType.DateTime;
					case 916:
						return FIXType.DateTime;
					case 917:
						return FIXType.DateTime;
					case 918:
						return FIXType.Double;
					case 919:
						return FIXType.Int;
					case 920:
						return FIXType.Double;
					case 921:
						return FIXType.Double;
					case 922:
						return FIXType.Double;
					case 923:
						return FIXType.String;
					case 924:
						return FIXType.Int;
					case 925:
						return FIXType.String;
					case 926:
						return FIXType.Int;
					case 927:
						return FIXType.String;
					case 928:
						return FIXType.Int;
					case 929:
						return FIXType.String;
					case 930:
						return FIXType.String;
					case 931:
						return FIXType.String;
					case 932:
						return FIXType.String;
					case 933:
						return FIXType.String;
					case 934:
						return FIXType.String;
					case 935:
						return FIXType.Int;
					case 936:
						return FIXType.Int;
					case 937:
						return FIXType.Int;
					case 938:
						return FIXType.Int;
					case 939:
						return FIXType.Int;
					case 940:
						return FIXType.Int;
					case 941:
						return FIXType.Double;
					case 942:
						return FIXType.Double;
					case 943:
						return FIXType.String;
					case 944:
						return FIXType.Int;
					case 945:
						return FIXType.Int;
					case 946:
						return FIXType.Int;
					case 947:
						return FIXType.Double;
					case 948:
						return FIXType.Int;
					case 949:
						return FIXType.String;
					case 950:
						return FIXType.Char;
					case 951:
						return FIXType.Int;
					case 952:
						return FIXType.Int;
					case 953:
						return FIXType.String;
					case 954:
						return FIXType.Int;
					case 955:
						return FIXType.String;
					case 956:
						return FIXType.DateTime;
					default:
						switch (tag)
						{
						case 10100:
							return FIXType.String;
						case 10101:
							return FIXType.String;
						case 10102:
							return FIXType.String;
						case 10103:
							return FIXType.String;
						}
						break;
					}
				}
				else
				{
					switch (tag)
					{
					case 10200:
						return FIXType.Int;
					case 10201:
						return FIXType.DateTime;
					case 10202:
						return FIXType.DateTime;
					case 10203:
						return FIXType.DateTime;
					case 10204:
						return FIXType.Int;
					case 10205:
						return FIXType.Int;
					case 10206:
						return FIXType.Int;
					case 10207:
						return FIXType.Double;
					case 10208:
						return FIXType.Double;
					case 10209:
						return FIXType.Double;
					case 10210:
						return FIXType.Double;
					case 10211:
						return FIXType.Double;
					default:
						switch (tag)
						{
						case 10300:
							return FIXType.Double;
						case 10301:
							return FIXType.Double;
						case 10302:
							return FIXType.Double;
						case 10303:
							return FIXType.Double;
						case 10304:
							return FIXType.Double;
						case 10305:
							return FIXType.Double;
						case 10306:
							return FIXType.Double;
						}
						break;
					}
				}
			}
			else if (tag <= 10700)
			{
				if (tag == 10400)
				{
					return FIXType.Double;
				}
				if (tag == 10700)
				{
					return FIXType.Bool;
				}
			}
			else
			{
				switch (tag)
				{
				case 10710:
					return FIXType.String;
				case 10711:
					return FIXType.String;
				case 10712:
					return FIXType.String;
				case 10713:
					return FIXType.Double;
				default:
					if (tag == 10800)
					{
						return FIXType.String;
					}
					if (tag == 11105)
					{
						return FIXType.String;
					}
					break;
				}
			}
			throw new ArgumentException("Tag does not exists : " + tag);
		}

		// Token: 0x040009AC RID: 2476
		public const FIXType Account = FIXType.String;

		// Token: 0x040009AD RID: 2477
		public const FIXType AdvId = FIXType.String;

		// Token: 0x040009AE RID: 2478
		public const FIXType AdvRefID = FIXType.String;

		// Token: 0x040009AF RID: 2479
		public const FIXType AdvSide = FIXType.Char;

		// Token: 0x040009B0 RID: 2480
		public const FIXType AdvTransType = FIXType.String;

		// Token: 0x040009B1 RID: 2481
		public const FIXType AvgPx = FIXType.Double;

		// Token: 0x040009B2 RID: 2482
		public const FIXType BeginSeqNo = FIXType.Int;

		// Token: 0x040009B3 RID: 2483
		public const FIXType BeginString = FIXType.String;

		// Token: 0x040009B4 RID: 2484
		public const FIXType BodyLength = FIXType.Int;

		// Token: 0x040009B5 RID: 2485
		public const FIXType CheckSum = FIXType.String;

		// Token: 0x040009B6 RID: 2486
		public const FIXType ClOrdID = FIXType.String;

		// Token: 0x040009B7 RID: 2487
		public const FIXType Commission = FIXType.Double;

		// Token: 0x040009B8 RID: 2488
		public const FIXType CommType = FIXType.Char;

		// Token: 0x040009B9 RID: 2489
		public const FIXType CumQty = FIXType.Double;

		// Token: 0x040009BA RID: 2490
		public const FIXType Currency = FIXType.Double;

		// Token: 0x040009BB RID: 2491
		public const FIXType EndSeqNo = FIXType.Int;

		// Token: 0x040009BC RID: 2492
		public const FIXType ExecID = FIXType.String;

		// Token: 0x040009BD RID: 2493
		public const FIXType ExecInst = FIXType.String;

		// Token: 0x040009BE RID: 2494
		public const FIXType ExecRefID = FIXType.String;

		// Token: 0x040009BF RID: 2495
		public const FIXType ExecTransType = FIXType.Char;

		// Token: 0x040009C0 RID: 2496
		public const FIXType HandlInst = FIXType.Char;

		// Token: 0x040009C1 RID: 2497
		public const FIXType SecurityIDSource = FIXType.String;

		// Token: 0x040009C2 RID: 2498
		public const FIXType IOIID = FIXType.String;

		// Token: 0x040009C3 RID: 2499
		public const FIXType IOIOthSvc = FIXType.Char;

		// Token: 0x040009C4 RID: 2500
		public const FIXType IOIQltyInd = FIXType.Char;

		// Token: 0x040009C5 RID: 2501
		public const FIXType IOIRefID = FIXType.String;

		// Token: 0x040009C6 RID: 2502
		public const FIXType IOIQty = FIXType.String;

		// Token: 0x040009C7 RID: 2503
		public const FIXType IOITransType = FIXType.Char;

		// Token: 0x040009C8 RID: 2504
		public const FIXType LastCapacity = FIXType.Char;

		// Token: 0x040009C9 RID: 2505
		public const FIXType LastMkt = FIXType.String;

		// Token: 0x040009CA RID: 2506
		public const FIXType LastPx = FIXType.Double;

		// Token: 0x040009CB RID: 2507
		public const FIXType LastQty = FIXType.Double;

		// Token: 0x040009CC RID: 2508
		public const FIXType NoLinesOfText = FIXType.Int;

		// Token: 0x040009CD RID: 2509
		public const FIXType MsgSeqNum = FIXType.Int;

		// Token: 0x040009CE RID: 2510
		public const FIXType MsgType = FIXType.String;

		// Token: 0x040009CF RID: 2511
		public const FIXType NewSeqNo = FIXType.Int;

		// Token: 0x040009D0 RID: 2512
		public const FIXType OrderID = FIXType.String;

		// Token: 0x040009D1 RID: 2513
		public const FIXType OrderQty = FIXType.Double;

		// Token: 0x040009D2 RID: 2514
		public const FIXType OrdStatus = FIXType.Char;

		// Token: 0x040009D3 RID: 2515
		public const FIXType OrdType = FIXType.Char;

		// Token: 0x040009D4 RID: 2516
		public const FIXType OrigClOrdID = FIXType.String;

		// Token: 0x040009D5 RID: 2517
		public const FIXType OrigTime = FIXType.DateTime;

		// Token: 0x040009D6 RID: 2518
		public const FIXType PossDupFlag = FIXType.Bool;

		// Token: 0x040009D7 RID: 2519
		public const FIXType Price = FIXType.Double;

		// Token: 0x040009D8 RID: 2520
		public const FIXType RefSeqNum = FIXType.Int;

		// Token: 0x040009D9 RID: 2521
		public const FIXType RelatdSym = FIXType.String;

		// Token: 0x040009DA RID: 2522
		public const FIXType Rule80A = FIXType.Char;

		// Token: 0x040009DB RID: 2523
		public const FIXType SecurityID = FIXType.String;

		// Token: 0x040009DC RID: 2524
		public const FIXType SenderCompID = FIXType.String;

		// Token: 0x040009DD RID: 2525
		public const FIXType SenderSubID = FIXType.String;

		// Token: 0x040009DE RID: 2526
		public const FIXType SendingDate = FIXType.DateTime;

		// Token: 0x040009DF RID: 2527
		public const FIXType SendingTime = FIXType.DateTime;

		// Token: 0x040009E0 RID: 2528
		public const FIXType Quantity = FIXType.Double;

		// Token: 0x040009E1 RID: 2529
		public const FIXType Side = FIXType.Char;

		// Token: 0x040009E2 RID: 2530
		public const FIXType Symbol = FIXType.String;

		// Token: 0x040009E3 RID: 2531
		public const FIXType TargetCompID = FIXType.String;

		// Token: 0x040009E4 RID: 2532
		public const FIXType TargetSubID = FIXType.String;

		// Token: 0x040009E5 RID: 2533
		public const FIXType Text = FIXType.String;

		// Token: 0x040009E6 RID: 2534
		public const FIXType TimeInForce = FIXType.Char;

		// Token: 0x040009E7 RID: 2535
		public const FIXType TransactTime = FIXType.DateTime;

		// Token: 0x040009E8 RID: 2536
		public const FIXType Urgency = FIXType.Char;

		// Token: 0x040009E9 RID: 2537
		public const FIXType ValidUntilTime = FIXType.DateTime;

		// Token: 0x040009EA RID: 2538
		public const FIXType SettlType = FIXType.Char;

		// Token: 0x040009EB RID: 2539
		public const FIXType SettlDate = FIXType.DateTime;

		// Token: 0x040009EC RID: 2540
		public const FIXType SymbolSfx = FIXType.String;

		// Token: 0x040009ED RID: 2541
		public const FIXType ListID = FIXType.String;

		// Token: 0x040009EE RID: 2542
		public const FIXType ListSeqNo = FIXType.Int;

		// Token: 0x040009EF RID: 2543
		public const FIXType TotNoOrders = FIXType.Int;

		// Token: 0x040009F0 RID: 2544
		public const FIXType ListExecInst = FIXType.String;

		// Token: 0x040009F1 RID: 2545
		public const FIXType AllocID = FIXType.String;

		// Token: 0x040009F2 RID: 2546
		public const FIXType AllocTransType = FIXType.Char;

		// Token: 0x040009F3 RID: 2547
		public const FIXType RefAllocID = FIXType.String;

		// Token: 0x040009F4 RID: 2548
		public const FIXType NoOrders = FIXType.Int;

		// Token: 0x040009F5 RID: 2549
		public const FIXType AvgPxPrecision = FIXType.Int;

		// Token: 0x040009F6 RID: 2550
		public const FIXType TradeDate = FIXType.DateTime;

		// Token: 0x040009F7 RID: 2551
		public const FIXType ExecBroker = FIXType.String;

		// Token: 0x040009F8 RID: 2552
		public const FIXType PositionEffect = FIXType.Char;

		// Token: 0x040009F9 RID: 2553
		public const FIXType NoAllocs = FIXType.Int;

		// Token: 0x040009FA RID: 2554
		public const FIXType AllocAccount = FIXType.String;

		// Token: 0x040009FB RID: 2555
		public const FIXType AllocQty = FIXType.Double;

		// Token: 0x040009FC RID: 2556
		public const FIXType ProcessCode = FIXType.Char;

		// Token: 0x040009FD RID: 2557
		public const FIXType NoRpts = FIXType.Int;

		// Token: 0x040009FE RID: 2558
		public const FIXType RptSeq = FIXType.Int;

		// Token: 0x040009FF RID: 2559
		public const FIXType CxlQty = FIXType.Double;

		// Token: 0x04000A00 RID: 2560
		public const FIXType NoDlvyInst = FIXType.Int;

		// Token: 0x04000A01 RID: 2561
		public const FIXType DlvyInst = FIXType.String;

		// Token: 0x04000A02 RID: 2562
		public const FIXType AllocStatus = FIXType.Int;

		// Token: 0x04000A03 RID: 2563
		public const FIXType AllocRejCode = FIXType.Int;

		// Token: 0x04000A04 RID: 2564
		public const FIXType Signature = FIXType.String;

		// Token: 0x04000A05 RID: 2565
		public const FIXType SecureDataLen = FIXType.Int;

		// Token: 0x04000A06 RID: 2566
		public const FIXType SecureData = FIXType.String;

		// Token: 0x04000A07 RID: 2567
		public const FIXType BrokerOfCredit = FIXType.String;

		// Token: 0x04000A08 RID: 2568
		public const FIXType SignatureLength = FIXType.Int;

		// Token: 0x04000A09 RID: 2569
		public const FIXType EmailType = FIXType.Char;

		// Token: 0x04000A0A RID: 2570
		public const FIXType RawDataLength = FIXType.Int;

		// Token: 0x04000A0B RID: 2571
		public const FIXType RawData = FIXType.String;

		// Token: 0x04000A0C RID: 2572
		public const FIXType PossResend = FIXType.Bool;

		// Token: 0x04000A0D RID: 2573
		public const FIXType EncryptMethod = FIXType.Int;

		// Token: 0x04000A0E RID: 2574
		public const FIXType StopPx = FIXType.Double;

		// Token: 0x04000A0F RID: 2575
		public const FIXType ExDestination = FIXType.String;

		// Token: 0x04000A10 RID: 2576
		public const FIXType CxlRejReason = FIXType.Int;

		// Token: 0x04000A11 RID: 2577
		public const FIXType OrdRejReason = FIXType.Int;

		// Token: 0x04000A12 RID: 2578
		public const FIXType IOIQualifier = FIXType.Char;

		// Token: 0x04000A13 RID: 2579
		public const FIXType WaveNo = FIXType.String;

		// Token: 0x04000A14 RID: 2580
		public const FIXType Issuer = FIXType.String;

		// Token: 0x04000A15 RID: 2581
		public const FIXType SecurityDesc = FIXType.String;

		// Token: 0x04000A16 RID: 2582
		public const FIXType HeartBtInt = FIXType.Int;

		// Token: 0x04000A17 RID: 2583
		public const FIXType ClientID = FIXType.String;

		// Token: 0x04000A18 RID: 2584
		public const FIXType MinQty = FIXType.Double;

		// Token: 0x04000A19 RID: 2585
		public const FIXType MaxFloor = FIXType.Double;

		// Token: 0x04000A1A RID: 2586
		public const FIXType TestReqID = FIXType.String;

		// Token: 0x04000A1B RID: 2587
		public const FIXType ReportToExch = FIXType.Bool;

		// Token: 0x04000A1C RID: 2588
		public const FIXType LocateReqd = FIXType.Bool;

		// Token: 0x04000A1D RID: 2589
		public const FIXType OnBehalfOfCompID = FIXType.String;

		// Token: 0x04000A1E RID: 2590
		public const FIXType OnBehalfOfSubID = FIXType.String;

		// Token: 0x04000A1F RID: 2591
		public const FIXType QuoteID = FIXType.String;

		// Token: 0x04000A20 RID: 2592
		public const FIXType NetMoney = FIXType.Double;

		// Token: 0x04000A21 RID: 2593
		public const FIXType SettlCurrAmt = FIXType.Double;

		// Token: 0x04000A22 RID: 2594
		public const FIXType SettlCurrency = FIXType.Double;

		// Token: 0x04000A23 RID: 2595
		public const FIXType ForexReq = FIXType.Bool;

		// Token: 0x04000A24 RID: 2596
		public const FIXType OrigSendingTime = FIXType.DateTime;

		// Token: 0x04000A25 RID: 2597
		public const FIXType GapFillFlag = FIXType.Bool;

		// Token: 0x04000A26 RID: 2598
		public const FIXType NoExecs = FIXType.Int;

		// Token: 0x04000A27 RID: 2599
		public const FIXType CxlType = FIXType.Char;

		// Token: 0x04000A28 RID: 2600
		public const FIXType ExpireTime = FIXType.DateTime;

		// Token: 0x04000A29 RID: 2601
		public const FIXType DKReason = FIXType.Char;

		// Token: 0x04000A2A RID: 2602
		public const FIXType DeliverToCompID = FIXType.String;

		// Token: 0x04000A2B RID: 2603
		public const FIXType DeliverToSubID = FIXType.String;

		// Token: 0x04000A2C RID: 2604
		public const FIXType IOINaturalFlag = FIXType.Bool;

		// Token: 0x04000A2D RID: 2605
		public const FIXType QuoteReqID = FIXType.String;

		// Token: 0x04000A2E RID: 2606
		public const FIXType BidPx = FIXType.Double;

		// Token: 0x04000A2F RID: 2607
		public const FIXType OfferPx = FIXType.Double;

		// Token: 0x04000A30 RID: 2608
		public const FIXType BidSize = FIXType.Double;

		// Token: 0x04000A31 RID: 2609
		public const FIXType OfferSize = FIXType.Double;

		// Token: 0x04000A32 RID: 2610
		public const FIXType NoMiscFees = FIXType.Int;

		// Token: 0x04000A33 RID: 2611
		public const FIXType MiscFeeAmt = FIXType.Double;

		// Token: 0x04000A34 RID: 2612
		public const FIXType MiscFeeCurr = FIXType.Double;

		// Token: 0x04000A35 RID: 2613
		public const FIXType MiscFeeType = FIXType.Char;

		// Token: 0x04000A36 RID: 2614
		public const FIXType PrevClosePx = FIXType.Double;

		// Token: 0x04000A37 RID: 2615
		public const FIXType ResetSeqNumFlag = FIXType.Bool;

		// Token: 0x04000A38 RID: 2616
		public const FIXType SenderLocationID = FIXType.String;

		// Token: 0x04000A39 RID: 2617
		public const FIXType TargetLocationID = FIXType.String;

		// Token: 0x04000A3A RID: 2618
		public const FIXType OnBehalfOfLocationID = FIXType.String;

		// Token: 0x04000A3B RID: 2619
		public const FIXType DeliverToLocationID = FIXType.String;

		// Token: 0x04000A3C RID: 2620
		public const FIXType NoRelatedSym = FIXType.Int;

		// Token: 0x04000A3D RID: 2621
		public const FIXType Subject = FIXType.String;

		// Token: 0x04000A3E RID: 2622
		public const FIXType Headline = FIXType.String;

		// Token: 0x04000A3F RID: 2623
		public const FIXType URLLink = FIXType.String;

		// Token: 0x04000A40 RID: 2624
		public const FIXType ExecType = FIXType.Char;

		// Token: 0x04000A41 RID: 2625
		public const FIXType LeavesQty = FIXType.Double;

		// Token: 0x04000A42 RID: 2626
		public const FIXType CashOrderQty = FIXType.Double;

		// Token: 0x04000A43 RID: 2627
		public const FIXType AllocAvgPx = FIXType.Double;

		// Token: 0x04000A44 RID: 2628
		public const FIXType AllocNetMoney = FIXType.Double;

		// Token: 0x04000A45 RID: 2629
		public const FIXType SettlCurrFxRate = FIXType.Double;

		// Token: 0x04000A46 RID: 2630
		public const FIXType SettlCurrFxRateCalc = FIXType.Char;

		// Token: 0x04000A47 RID: 2631
		public const FIXType NumDaysInterest = FIXType.Int;

		// Token: 0x04000A48 RID: 2632
		public const FIXType AccruedInterestRate = FIXType.Double;

		// Token: 0x04000A49 RID: 2633
		public const FIXType AccruedInterestAmt = FIXType.Double;

		// Token: 0x04000A4A RID: 2634
		public const FIXType SettlInstMode = FIXType.Char;

		// Token: 0x04000A4B RID: 2635
		public const FIXType AllocText = FIXType.String;

		// Token: 0x04000A4C RID: 2636
		public const FIXType SettlInstID = FIXType.String;

		// Token: 0x04000A4D RID: 2637
		public const FIXType SettlInstTransType = FIXType.Char;

		// Token: 0x04000A4E RID: 2638
		public const FIXType EmailThreadID = FIXType.String;

		// Token: 0x04000A4F RID: 2639
		public const FIXType SettlInstSource = FIXType.Char;

		// Token: 0x04000A50 RID: 2640
		public const FIXType SettlLocation = FIXType.String;

		// Token: 0x04000A51 RID: 2641
		public const FIXType SecurityType = FIXType.String;

		// Token: 0x04000A52 RID: 2642
		public const FIXType EffectiveTime = FIXType.DateTime;

		// Token: 0x04000A53 RID: 2643
		public const FIXType StandInstDbType = FIXType.Int;

		// Token: 0x04000A54 RID: 2644
		public const FIXType StandInstDbName = FIXType.String;

		// Token: 0x04000A55 RID: 2645
		public const FIXType StandInstDbID = FIXType.String;

		// Token: 0x04000A56 RID: 2646
		public const FIXType SettlDeliveryType = FIXType.Int;

		// Token: 0x04000A57 RID: 2647
		public const FIXType SettlDepositoryCode_ = FIXType.String;

		// Token: 0x04000A58 RID: 2648
		public const FIXType SettlBrkrCode_ = FIXType.String;

		// Token: 0x04000A59 RID: 2649
		public const FIXType SettlInstCode_ = FIXType.String;

		// Token: 0x04000A5A RID: 2650
		public const FIXType SecuritySettlAgentName = FIXType.String;

		// Token: 0x04000A5B RID: 2651
		public const FIXType SecuritySettlAgentCode = FIXType.String;

		// Token: 0x04000A5C RID: 2652
		public const FIXType SecuritySettlAgentAcctNum = FIXType.String;

		// Token: 0x04000A5D RID: 2653
		public const FIXType SecuritySettlAgentAcctName = FIXType.String;

		// Token: 0x04000A5E RID: 2654
		public const FIXType SecuritySettlAgentContactName = FIXType.String;

		// Token: 0x04000A5F RID: 2655
		public const FIXType SecuritySettlAgentContactPhone = FIXType.String;

		// Token: 0x04000A60 RID: 2656
		public const FIXType CashSettlAgentName = FIXType.String;

		// Token: 0x04000A61 RID: 2657
		public const FIXType CashSettlAgentCode = FIXType.String;

		// Token: 0x04000A62 RID: 2658
		public const FIXType CashSettlAgentAcctNum = FIXType.String;

		// Token: 0x04000A63 RID: 2659
		public const FIXType CashSettlAgentAcctName = FIXType.String;

		// Token: 0x04000A64 RID: 2660
		public const FIXType CashSettlAgentContactName = FIXType.String;

		// Token: 0x04000A65 RID: 2661
		public const FIXType CashSettlAgentContactPhone = FIXType.String;

		// Token: 0x04000A66 RID: 2662
		public const FIXType BidSpotRate = FIXType.Double;

		// Token: 0x04000A67 RID: 2663
		public const FIXType BidForwardPoints = FIXType.Double;

		// Token: 0x04000A68 RID: 2664
		public const FIXType OfferSpotRate = FIXType.Double;

		// Token: 0x04000A69 RID: 2665
		public const FIXType OfferForwardPoints = FIXType.Double;

		// Token: 0x04000A6A RID: 2666
		public const FIXType OrderQty2 = FIXType.Double;

		// Token: 0x04000A6B RID: 2667
		public const FIXType SettlDate2 = FIXType.DateTime;

		// Token: 0x04000A6C RID: 2668
		public const FIXType LastSpotRate = FIXType.Double;

		// Token: 0x04000A6D RID: 2669
		public const FIXType LastForwardPoints = FIXType.Double;

		// Token: 0x04000A6E RID: 2670
		public const FIXType AllocLinkID = FIXType.String;

		// Token: 0x04000A6F RID: 2671
		public const FIXType AllocLinkType = FIXType.Int;

		// Token: 0x04000A70 RID: 2672
		public const FIXType SecondaryOrderID = FIXType.String;

		// Token: 0x04000A71 RID: 2673
		public const FIXType NoIOIQualifiers = FIXType.Int;

		// Token: 0x04000A72 RID: 2674
		public const FIXType MaturityMonthYear = FIXType.String;

		// Token: 0x04000A73 RID: 2675
		public const FIXType PutOrCall = FIXType.Int;

		// Token: 0x04000A74 RID: 2676
		public const FIXType StrikePrice = FIXType.Double;

		// Token: 0x04000A75 RID: 2677
		public const FIXType CoveredOrUncovered = FIXType.Int;

		// Token: 0x04000A76 RID: 2678
		public const FIXType CustomerOrFirm = FIXType.Int;

		// Token: 0x04000A77 RID: 2679
		public const FIXType MaturityDay = FIXType.DateTime;

		// Token: 0x04000A78 RID: 2680
		public const FIXType OptAttribute = FIXType.Char;

		// Token: 0x04000A79 RID: 2681
		public const FIXType SecurityExchange = FIXType.String;

		// Token: 0x04000A7A RID: 2682
		public const FIXType NotifyBrokerOfCredit = FIXType.Bool;

		// Token: 0x04000A7B RID: 2683
		public const FIXType AllocHandlInst = FIXType.Int;

		// Token: 0x04000A7C RID: 2684
		public const FIXType MaxShow = FIXType.Double;

		// Token: 0x04000A7D RID: 2685
		public const FIXType PegOffsetValue = FIXType.Double;

		// Token: 0x04000A7E RID: 2686
		public const FIXType XmlDataLen = FIXType.Int;

		// Token: 0x04000A7F RID: 2687
		public const FIXType XmlData = FIXType.String;

		// Token: 0x04000A80 RID: 2688
		public const FIXType SettlInstRefID = FIXType.String;

		// Token: 0x04000A81 RID: 2689
		public const FIXType NoRoutingIDs = FIXType.Int;

		// Token: 0x04000A82 RID: 2690
		public const FIXType RoutingType = FIXType.Int;

		// Token: 0x04000A83 RID: 2691
		public const FIXType RoutingID = FIXType.String;

		// Token: 0x04000A84 RID: 2692
		public const FIXType Spread = FIXType.Double;

		// Token: 0x04000A85 RID: 2693
		public const FIXType Benchmark = FIXType.Char;

		// Token: 0x04000A86 RID: 2694
		public const FIXType BenchmarkCurveCurrency = FIXType.Double;

		// Token: 0x04000A87 RID: 2695
		public const FIXType BenchmarkCurveName = FIXType.String;

		// Token: 0x04000A88 RID: 2696
		public const FIXType BenchmarkCurvePoint = FIXType.String;

		// Token: 0x04000A89 RID: 2697
		public const FIXType CouponRate = FIXType.Double;

		// Token: 0x04000A8A RID: 2698
		public const FIXType CouponPaymentDate = FIXType.DateTime;

		// Token: 0x04000A8B RID: 2699
		public const FIXType IssueDate = FIXType.DateTime;

		// Token: 0x04000A8C RID: 2700
		public const FIXType RepurchaseTerm = FIXType.Int;

		// Token: 0x04000A8D RID: 2701
		public const FIXType RepurchaseRate = FIXType.Double;

		// Token: 0x04000A8E RID: 2702
		public const FIXType Factor = FIXType.Double;

		// Token: 0x04000A8F RID: 2703
		public const FIXType TradeOriginationDate = FIXType.DateTime;

		// Token: 0x04000A90 RID: 2704
		public const FIXType ExDate = FIXType.DateTime;

		// Token: 0x04000A91 RID: 2705
		public const FIXType ContractMultiplier = FIXType.Double;

		// Token: 0x04000A92 RID: 2706
		public const FIXType NoStipulations = FIXType.Int;

		// Token: 0x04000A93 RID: 2707
		public const FIXType StipulationType = FIXType.String;

		// Token: 0x04000A94 RID: 2708
		public const FIXType StipulationValue = FIXType.String;

		// Token: 0x04000A95 RID: 2709
		public const FIXType YieldType = FIXType.String;

		// Token: 0x04000A96 RID: 2710
		public const FIXType Yield = FIXType.Double;

		// Token: 0x04000A97 RID: 2711
		public const FIXType TotalTakedown = FIXType.Double;

		// Token: 0x04000A98 RID: 2712
		public const FIXType Concession = FIXType.Double;

		// Token: 0x04000A99 RID: 2713
		public const FIXType RepoCollateralSecurityType = FIXType.Int;

		// Token: 0x04000A9A RID: 2714
		public const FIXType RedemptionDate = FIXType.DateTime;

		// Token: 0x04000A9B RID: 2715
		public const FIXType UnderlyingCouponPaymentDate = FIXType.DateTime;

		// Token: 0x04000A9C RID: 2716
		public const FIXType UnderlyingIssueDate = FIXType.DateTime;

		// Token: 0x04000A9D RID: 2717
		public const FIXType UnderlyingRepoCollateralSecurityType = FIXType.Int;

		// Token: 0x04000A9E RID: 2718
		public const FIXType UnderlyingRepurchaseTerm = FIXType.Int;

		// Token: 0x04000A9F RID: 2719
		public const FIXType UnderlyingRepurchaseRate = FIXType.Double;

		// Token: 0x04000AA0 RID: 2720
		public const FIXType UnderlyingFactor = FIXType.Double;

		// Token: 0x04000AA1 RID: 2721
		public const FIXType UnderlyingRedemptionDate = FIXType.DateTime;

		// Token: 0x04000AA2 RID: 2722
		public const FIXType LegCouponPaymentDate = FIXType.DateTime;

		// Token: 0x04000AA3 RID: 2723
		public const FIXType LegIssueDate = FIXType.DateTime;

		// Token: 0x04000AA4 RID: 2724
		public const FIXType LegRepoCollateralSecurityType = FIXType.Int;

		// Token: 0x04000AA5 RID: 2725
		public const FIXType LegRepurchaseTerm = FIXType.Int;

		// Token: 0x04000AA6 RID: 2726
		public const FIXType LegRepurchaseRate = FIXType.Double;

		// Token: 0x04000AA7 RID: 2727
		public const FIXType LegFactor = FIXType.Double;

		// Token: 0x04000AA8 RID: 2728
		public const FIXType LegRedemptionDate = FIXType.DateTime;

		// Token: 0x04000AA9 RID: 2729
		public const FIXType CreditRating = FIXType.String;

		// Token: 0x04000AAA RID: 2730
		public const FIXType UnderlyingCreditRating = FIXType.String;

		// Token: 0x04000AAB RID: 2731
		public const FIXType LegCreditRating = FIXType.String;

		// Token: 0x04000AAC RID: 2732
		public const FIXType TradedFlatSwitch = FIXType.Bool;

		// Token: 0x04000AAD RID: 2733
		public const FIXType BasisFeatureDate = FIXType.DateTime;

		// Token: 0x04000AAE RID: 2734
		public const FIXType BasisFeaturePrice = FIXType.Double;

		// Token: 0x04000AAF RID: 2735
		public const FIXType MDReqID = FIXType.String;

		// Token: 0x04000AB0 RID: 2736
		public const FIXType SubscriptionRequestType = FIXType.Char;

		// Token: 0x04000AB1 RID: 2737
		public const FIXType MarketDepth = FIXType.Int;

		// Token: 0x04000AB2 RID: 2738
		public const FIXType MDUpdateType = FIXType.Int;

		// Token: 0x04000AB3 RID: 2739
		public const FIXType AggregatedBook = FIXType.Char;

		// Token: 0x04000AB4 RID: 2740
		public const FIXType NoMDEntryTypes = FIXType.Int;

		// Token: 0x04000AB5 RID: 2741
		public const FIXType NoMDEntries = FIXType.Int;

		// Token: 0x04000AB6 RID: 2742
		public const FIXType MDEntryType = FIXType.Char;

		// Token: 0x04000AB7 RID: 2743
		public const FIXType MDEntryPx = FIXType.Double;

		// Token: 0x04000AB8 RID: 2744
		public const FIXType MDEntrySize = FIXType.Double;

		// Token: 0x04000AB9 RID: 2745
		public const FIXType MDEntryDate = FIXType.DateTime;

		// Token: 0x04000ABA RID: 2746
		public const FIXType MDEntryTime = FIXType.DateTime;

		// Token: 0x04000ABB RID: 2747
		public const FIXType TickDirection = FIXType.Char;

		// Token: 0x04000ABC RID: 2748
		public const FIXType MDMkt = FIXType.String;

		// Token: 0x04000ABD RID: 2749
		public const FIXType QuoteCondition = FIXType.String;

		// Token: 0x04000ABE RID: 2750
		public const FIXType TradeCondition = FIXType.String;

		// Token: 0x04000ABF RID: 2751
		public const FIXType MDEntryID = FIXType.String;

		// Token: 0x04000AC0 RID: 2752
		public const FIXType MDUpdateAction = FIXType.Char;

		// Token: 0x04000AC1 RID: 2753
		public const FIXType MDEntryRefID = FIXType.String;

		// Token: 0x04000AC2 RID: 2754
		public const FIXType MDReqRejReason = FIXType.Char;

		// Token: 0x04000AC3 RID: 2755
		public const FIXType MDEntryOriginator = FIXType.String;

		// Token: 0x04000AC4 RID: 2756
		public const FIXType LocationID = FIXType.String;

		// Token: 0x04000AC5 RID: 2757
		public const FIXType DeskID = FIXType.String;

		// Token: 0x04000AC6 RID: 2758
		public const FIXType DeleteReason = FIXType.Char;

		// Token: 0x04000AC7 RID: 2759
		public const FIXType OpenCloseSettlFlag = FIXType.String;

		// Token: 0x04000AC8 RID: 2760
		public const FIXType SellerDays = FIXType.Int;

		// Token: 0x04000AC9 RID: 2761
		public const FIXType MDEntryBuyer = FIXType.String;

		// Token: 0x04000ACA RID: 2762
		public const FIXType MDEntrySeller = FIXType.String;

		// Token: 0x04000ACB RID: 2763
		public const FIXType MDEntryPositionNo = FIXType.Int;

		// Token: 0x04000ACC RID: 2764
		public const FIXType FinancialStatus = FIXType.String;

		// Token: 0x04000ACD RID: 2765
		public const FIXType CorporateAction = FIXType.String;

		// Token: 0x04000ACE RID: 2766
		public const FIXType DefBidSize = FIXType.Double;

		// Token: 0x04000ACF RID: 2767
		public const FIXType DefOfferSize = FIXType.Double;

		// Token: 0x04000AD0 RID: 2768
		public const FIXType NoQuoteEntries = FIXType.Int;

		// Token: 0x04000AD1 RID: 2769
		public const FIXType NoQuoteSets = FIXType.Int;

		// Token: 0x04000AD2 RID: 2770
		public const FIXType QuoteStatus = FIXType.Int;

		// Token: 0x04000AD3 RID: 2771
		public const FIXType QuoteCancelType = FIXType.Int;

		// Token: 0x04000AD4 RID: 2772
		public const FIXType QuoteEntryID = FIXType.String;

		// Token: 0x04000AD5 RID: 2773
		public const FIXType QuoteRejectReason = FIXType.Int;

		// Token: 0x04000AD6 RID: 2774
		public const FIXType QuoteResponseLevel = FIXType.Int;

		// Token: 0x04000AD7 RID: 2775
		public const FIXType QuoteSetID = FIXType.String;

		// Token: 0x04000AD8 RID: 2776
		public const FIXType QuoteRequestType = FIXType.Int;

		// Token: 0x04000AD9 RID: 2777
		public const FIXType TotNoQuoteEntries = FIXType.Int;

		// Token: 0x04000ADA RID: 2778
		public const FIXType UnderlyingSecurityIDSource = FIXType.String;

		// Token: 0x04000ADB RID: 2779
		public const FIXType UnderlyingIssuer = FIXType.String;

		// Token: 0x04000ADC RID: 2780
		public const FIXType UnderlyingSecurityDesc = FIXType.String;

		// Token: 0x04000ADD RID: 2781
		public const FIXType UnderlyingSecurityExchange = FIXType.String;

		// Token: 0x04000ADE RID: 2782
		public const FIXType UnderlyingSecurityID = FIXType.String;

		// Token: 0x04000ADF RID: 2783
		public const FIXType UnderlyingSecurityType = FIXType.String;

		// Token: 0x04000AE0 RID: 2784
		public const FIXType UnderlyingSymbol = FIXType.String;

		// Token: 0x04000AE1 RID: 2785
		public const FIXType UnderlyingSymbolSfx = FIXType.String;

		// Token: 0x04000AE2 RID: 2786
		public const FIXType UnderlyingMaturityMonthYear = FIXType.String;

		// Token: 0x04000AE3 RID: 2787
		public const FIXType UnderlyingMaturityDay = FIXType.DateTime;

		// Token: 0x04000AE4 RID: 2788
		public const FIXType UnderlyingPutOrCall = FIXType.Int;

		// Token: 0x04000AE5 RID: 2789
		public const FIXType UnderlyingStrikePrice = FIXType.Double;

		// Token: 0x04000AE6 RID: 2790
		public const FIXType UnderlyingOptAttribute = FIXType.Char;

		// Token: 0x04000AE7 RID: 2791
		public const FIXType UnderlyingCurrency = FIXType.Double;

		// Token: 0x04000AE8 RID: 2792
		public const FIXType RatioQty = FIXType.Double;

		// Token: 0x04000AE9 RID: 2793
		public const FIXType SecurityReqID = FIXType.String;

		// Token: 0x04000AEA RID: 2794
		public const FIXType SecurityRequestType = FIXType.Int;

		// Token: 0x04000AEB RID: 2795
		public const FIXType SecurityResponseID = FIXType.String;

		// Token: 0x04000AEC RID: 2796
		public const FIXType SecurityResponseType = FIXType.Int;

		// Token: 0x04000AED RID: 2797
		public const FIXType SecurityStatusReqID = FIXType.String;

		// Token: 0x04000AEE RID: 2798
		public const FIXType UnsolicitedIndicator = FIXType.Bool;

		// Token: 0x04000AEF RID: 2799
		public const FIXType SecurityTradingStatus = FIXType.Int;

		// Token: 0x04000AF0 RID: 2800
		public const FIXType HaltReason = FIXType.Char;

		// Token: 0x04000AF1 RID: 2801
		public const FIXType InViewOfCommon = FIXType.Bool;

		// Token: 0x04000AF2 RID: 2802
		public const FIXType DueToRelated = FIXType.Bool;

		// Token: 0x04000AF3 RID: 2803
		public const FIXType BuyVolume = FIXType.Double;

		// Token: 0x04000AF4 RID: 2804
		public const FIXType SellVolume = FIXType.Double;

		// Token: 0x04000AF5 RID: 2805
		public const FIXType HighPx = FIXType.Double;

		// Token: 0x04000AF6 RID: 2806
		public const FIXType LowPx = FIXType.Double;

		// Token: 0x04000AF7 RID: 2807
		public const FIXType Adjustment = FIXType.Int;

		// Token: 0x04000AF8 RID: 2808
		public const FIXType TradSesReqID = FIXType.String;

		// Token: 0x04000AF9 RID: 2809
		public const FIXType TradingSessionID = FIXType.String;

		// Token: 0x04000AFA RID: 2810
		public const FIXType ContraTrader = FIXType.String;

		// Token: 0x04000AFB RID: 2811
		public const FIXType TradSesMethod = FIXType.Int;

		// Token: 0x04000AFC RID: 2812
		public const FIXType TradSesMode = FIXType.Int;

		// Token: 0x04000AFD RID: 2813
		public const FIXType TradSesStatus = FIXType.Int;

		// Token: 0x04000AFE RID: 2814
		public const FIXType TradSesStartTime = FIXType.DateTime;

		// Token: 0x04000AFF RID: 2815
		public const FIXType TradSesOpenTime = FIXType.DateTime;

		// Token: 0x04000B00 RID: 2816
		public const FIXType TradSesPreCloseTime = FIXType.DateTime;

		// Token: 0x04000B01 RID: 2817
		public const FIXType TradSesCloseTime = FIXType.DateTime;

		// Token: 0x04000B02 RID: 2818
		public const FIXType TradSesEndTime = FIXType.DateTime;

		// Token: 0x04000B03 RID: 2819
		public const FIXType NumberOfOrders = FIXType.Int;

		// Token: 0x04000B04 RID: 2820
		public const FIXType MessageEncoding = FIXType.String;

		// Token: 0x04000B05 RID: 2821
		public const FIXType EncodedIssuerLen = FIXType.Int;

		// Token: 0x04000B06 RID: 2822
		public const FIXType EncodedIssuer = FIXType.String;

		// Token: 0x04000B07 RID: 2823
		public const FIXType EncodedSecurityDescLen = FIXType.Int;

		// Token: 0x04000B08 RID: 2824
		public const FIXType EncodedSecurityDesc = FIXType.String;

		// Token: 0x04000B09 RID: 2825
		public const FIXType EncodedListExecInstLen = FIXType.Int;

		// Token: 0x04000B0A RID: 2826
		public const FIXType EncodedListExecInst = FIXType.String;

		// Token: 0x04000B0B RID: 2827
		public const FIXType EncodedTextLen = FIXType.Int;

		// Token: 0x04000B0C RID: 2828
		public const FIXType EncodedText = FIXType.String;

		// Token: 0x04000B0D RID: 2829
		public const FIXType EncodedSubjectLen = FIXType.Int;

		// Token: 0x04000B0E RID: 2830
		public const FIXType EncodedSubject = FIXType.String;

		// Token: 0x04000B0F RID: 2831
		public const FIXType EncodedHeadlineLen = FIXType.Int;

		// Token: 0x04000B10 RID: 2832
		public const FIXType EncodedHeadline = FIXType.String;

		// Token: 0x04000B11 RID: 2833
		public const FIXType EncodedAllocTextLen = FIXType.Int;

		// Token: 0x04000B12 RID: 2834
		public const FIXType EncodedAllocText = FIXType.String;

		// Token: 0x04000B13 RID: 2835
		public const FIXType EncodedUnderlyingIssuerLen = FIXType.Int;

		// Token: 0x04000B14 RID: 2836
		public const FIXType EncodedUnderlyingIssuer = FIXType.String;

		// Token: 0x04000B15 RID: 2837
		public const FIXType EncodedUnderlyingSecurityDescLen = FIXType.Int;

		// Token: 0x04000B16 RID: 2838
		public const FIXType EncodedUnderlyingSecurityDesc = FIXType.String;

		// Token: 0x04000B17 RID: 2839
		public const FIXType AllocPrice = FIXType.Double;

		// Token: 0x04000B18 RID: 2840
		public const FIXType QuoteSetValidUntilTime = FIXType.DateTime;

		// Token: 0x04000B19 RID: 2841
		public const FIXType QuoteEntryRejectReason = FIXType.Int;

		// Token: 0x04000B1A RID: 2842
		public const FIXType LastMsgSeqNumProcessed = FIXType.Int;

		// Token: 0x04000B1B RID: 2843
		public const FIXType OnBehalfOfSendingTime = FIXType.DateTime;

		// Token: 0x04000B1C RID: 2844
		public const FIXType RefTagID = FIXType.Int;

		// Token: 0x04000B1D RID: 2845
		public const FIXType RefMsgType = FIXType.String;

		// Token: 0x04000B1E RID: 2846
		public const FIXType SessionRejectReason = FIXType.Int;

		// Token: 0x04000B1F RID: 2847
		public const FIXType BidRequestTransType = FIXType.Char;

		// Token: 0x04000B20 RID: 2848
		public const FIXType ContraBroker = FIXType.String;

		// Token: 0x04000B21 RID: 2849
		public const FIXType ComplianceID = FIXType.String;

		// Token: 0x04000B22 RID: 2850
		public const FIXType SolicitedFlag = FIXType.Bool;

		// Token: 0x04000B23 RID: 2851
		public const FIXType ExecRestatementReason = FIXType.Int;

		// Token: 0x04000B24 RID: 2852
		public const FIXType BusinessRejectRefID = FIXType.String;

		// Token: 0x04000B25 RID: 2853
		public const FIXType BusinessRejectReason = FIXType.Int;

		// Token: 0x04000B26 RID: 2854
		public const FIXType GrossTradeAmt = FIXType.Double;

		// Token: 0x04000B27 RID: 2855
		public const FIXType NoContraBrokers = FIXType.Int;

		// Token: 0x04000B28 RID: 2856
		public const FIXType MaxMessageSize = FIXType.Int;

		// Token: 0x04000B29 RID: 2857
		public const FIXType NoMsgTypes = FIXType.Int;

		// Token: 0x04000B2A RID: 2858
		public const FIXType MsgDirection = FIXType.Char;

		// Token: 0x04000B2B RID: 2859
		public const FIXType NoTradingSessions = FIXType.Int;

		// Token: 0x04000B2C RID: 2860
		public const FIXType TotalVolumeTraded = FIXType.Double;

		// Token: 0x04000B2D RID: 2861
		public const FIXType DiscretionInst = FIXType.Char;

		// Token: 0x04000B2E RID: 2862
		public const FIXType DiscretionOffsetValue = FIXType.Double;

		// Token: 0x04000B2F RID: 2863
		public const FIXType BidID = FIXType.String;

		// Token: 0x04000B30 RID: 2864
		public const FIXType ClientBidID = FIXType.String;

		// Token: 0x04000B31 RID: 2865
		public const FIXType ListName = FIXType.String;

		// Token: 0x04000B32 RID: 2866
		public const FIXType TotNoRelatedSym = FIXType.Int;

		// Token: 0x04000B33 RID: 2867
		public const FIXType BidType = FIXType.Int;

		// Token: 0x04000B34 RID: 2868
		public const FIXType NumTickets = FIXType.Int;

		// Token: 0x04000B35 RID: 2869
		public const FIXType SideValue1 = FIXType.Double;

		// Token: 0x04000B36 RID: 2870
		public const FIXType SideValue2 = FIXType.Double;

		// Token: 0x04000B37 RID: 2871
		public const FIXType NoBidDescriptors = FIXType.Int;

		// Token: 0x04000B38 RID: 2872
		public const FIXType BidDescriptorType = FIXType.Int;

		// Token: 0x04000B39 RID: 2873
		public const FIXType BidDescriptor = FIXType.String;

		// Token: 0x04000B3A RID: 2874
		public const FIXType SideValueInd = FIXType.Int;

		// Token: 0x04000B3B RID: 2875
		public const FIXType LiquidityPctLow = FIXType.Double;

		// Token: 0x04000B3C RID: 2876
		public const FIXType LiquidityPctHigh = FIXType.Double;

		// Token: 0x04000B3D RID: 2877
		public const FIXType LiquidityValue = FIXType.Double;

		// Token: 0x04000B3E RID: 2878
		public const FIXType EFPTrackingError = FIXType.Double;

		// Token: 0x04000B3F RID: 2879
		public const FIXType FairValue = FIXType.Double;

		// Token: 0x04000B40 RID: 2880
		public const FIXType OutsideIndexPct = FIXType.Double;

		// Token: 0x04000B41 RID: 2881
		public const FIXType ValueOfFutures = FIXType.Double;

		// Token: 0x04000B42 RID: 2882
		public const FIXType LiquidityIndType = FIXType.Int;

		// Token: 0x04000B43 RID: 2883
		public const FIXType WtAverageLiquidity = FIXType.Double;

		// Token: 0x04000B44 RID: 2884
		public const FIXType ExchangeForPhysical = FIXType.Bool;

		// Token: 0x04000B45 RID: 2885
		public const FIXType OutMainCntryUIndex = FIXType.Double;

		// Token: 0x04000B46 RID: 2886
		public const FIXType CrossPercent = FIXType.Double;

		// Token: 0x04000B47 RID: 2887
		public const FIXType ProgRptReqs = FIXType.Int;

		// Token: 0x04000B48 RID: 2888
		public const FIXType ProgPeriodInterval = FIXType.Int;

		// Token: 0x04000B49 RID: 2889
		public const FIXType IncTaxInd = FIXType.Int;

		// Token: 0x04000B4A RID: 2890
		public const FIXType NumBidders = FIXType.Int;

		// Token: 0x04000B4B RID: 2891
		public const FIXType BidTradeType = FIXType.Char;

		// Token: 0x04000B4C RID: 2892
		public const FIXType BasisPxType = FIXType.Char;

		// Token: 0x04000B4D RID: 2893
		public const FIXType NoBidComponents = FIXType.Int;

		// Token: 0x04000B4E RID: 2894
		public const FIXType Country = FIXType.String;

		// Token: 0x04000B4F RID: 2895
		public const FIXType TotNoStrikes = FIXType.Int;

		// Token: 0x04000B50 RID: 2896
		public const FIXType PriceType = FIXType.Int;

		// Token: 0x04000B51 RID: 2897
		public const FIXType DayOrderQty = FIXType.Double;

		// Token: 0x04000B52 RID: 2898
		public const FIXType DayCumQty = FIXType.Double;

		// Token: 0x04000B53 RID: 2899
		public const FIXType DayAvgPx = FIXType.Double;

		// Token: 0x04000B54 RID: 2900
		public const FIXType GTBookingInst = FIXType.Int;

		// Token: 0x04000B55 RID: 2901
		public const FIXType NoStrikes = FIXType.Int;

		// Token: 0x04000B56 RID: 2902
		public const FIXType ListStatusType = FIXType.Int;

		// Token: 0x04000B57 RID: 2903
		public const FIXType NetGrossInd = FIXType.Int;

		// Token: 0x04000B58 RID: 2904
		public const FIXType ListOrderStatus = FIXType.Int;

		// Token: 0x04000B59 RID: 2905
		public const FIXType ExpireDate = FIXType.DateTime;

		// Token: 0x04000B5A RID: 2906
		public const FIXType ListExecInstType = FIXType.Char;

		// Token: 0x04000B5B RID: 2907
		public const FIXType CxlRejResponseTo = FIXType.Char;

		// Token: 0x04000B5C RID: 2908
		public const FIXType UnderlyingCouponRate = FIXType.Double;

		// Token: 0x04000B5D RID: 2909
		public const FIXType UnderlyingContractMultiplier = FIXType.Double;

		// Token: 0x04000B5E RID: 2910
		public const FIXType ContraTradeQty = FIXType.Double;

		// Token: 0x04000B5F RID: 2911
		public const FIXType ContraTradeTime = FIXType.DateTime;

		// Token: 0x04000B60 RID: 2912
		public const FIXType ClearingFirm = FIXType.String;

		// Token: 0x04000B61 RID: 2913
		public const FIXType ClearingAccount = FIXType.String;

		// Token: 0x04000B62 RID: 2914
		public const FIXType LiquidityNumSecurities = FIXType.Int;

		// Token: 0x04000B63 RID: 2915
		public const FIXType MultiLegReportingType = FIXType.Char;

		// Token: 0x04000B64 RID: 2916
		public const FIXType StrikeTime = FIXType.DateTime;

		// Token: 0x04000B65 RID: 2917
		public const FIXType ListStatusText = FIXType.String;

		// Token: 0x04000B66 RID: 2918
		public const FIXType EncodedListStatusTextLen = FIXType.Int;

		// Token: 0x04000B67 RID: 2919
		public const FIXType EncodedListStatusText = FIXType.String;

		// Token: 0x04000B68 RID: 2920
		public const FIXType PartyIDSource = FIXType.Char;

		// Token: 0x04000B69 RID: 2921
		public const FIXType PartyID = FIXType.String;

		// Token: 0x04000B6A RID: 2922
		public const FIXType TotalVolumeTradedDate = FIXType.DateTime;

		// Token: 0x04000B6B RID: 2923
		public const FIXType TotalVolumeTraded_Time = FIXType.DateTime;

		// Token: 0x04000B6C RID: 2924
		public const FIXType NetChgPrevDay = FIXType.Double;

		// Token: 0x04000B6D RID: 2925
		public const FIXType PartyRole = FIXType.Int;

		// Token: 0x04000B6E RID: 2926
		public const FIXType NoPartyIDs = FIXType.Int;

		// Token: 0x04000B6F RID: 2927
		public const FIXType NoSecurityAltID = FIXType.Int;

		// Token: 0x04000B70 RID: 2928
		public const FIXType SecurityAltID = FIXType.String;

		// Token: 0x04000B71 RID: 2929
		public const FIXType SecurityAltIDSource = FIXType.String;

		// Token: 0x04000B72 RID: 2930
		public const FIXType NoUnderlyingSecurityAltID = FIXType.Int;

		// Token: 0x04000B73 RID: 2931
		public const FIXType UnderlyingSecurityAltID = FIXType.String;

		// Token: 0x04000B74 RID: 2932
		public const FIXType UnderlyingSecurityAltIDSource = FIXType.String;

		// Token: 0x04000B75 RID: 2933
		public const FIXType Product = FIXType.Int;

		// Token: 0x04000B76 RID: 2934
		public const FIXType CFICode = FIXType.String;

		// Token: 0x04000B77 RID: 2935
		public const FIXType UnderlyingProduct = FIXType.Int;

		// Token: 0x04000B78 RID: 2936
		public const FIXType UnderlyingCFICode = FIXType.String;

		// Token: 0x04000B79 RID: 2937
		public const FIXType TestMessageIndicator = FIXType.Bool;

		// Token: 0x04000B7A RID: 2938
		public const FIXType QuantityType = FIXType.Int;

		// Token: 0x04000B7B RID: 2939
		public const FIXType BookingRefID = FIXType.String;

		// Token: 0x04000B7C RID: 2940
		public const FIXType IndividualAllocID = FIXType.String;

		// Token: 0x04000B7D RID: 2941
		public const FIXType RoundingDirection = FIXType.Char;

		// Token: 0x04000B7E RID: 2942
		public const FIXType RoundingModulus = FIXType.Double;

		// Token: 0x04000B7F RID: 2943
		public const FIXType CountryOfIssue = FIXType.String;

		// Token: 0x04000B80 RID: 2944
		public const FIXType StateOrProvinceOfIssue = FIXType.String;

		// Token: 0x04000B81 RID: 2945
		public const FIXType LocaleOfIssue = FIXType.String;

		// Token: 0x04000B82 RID: 2946
		public const FIXType NoRegistDtls = FIXType.Int;

		// Token: 0x04000B83 RID: 2947
		public const FIXType MailingDtls = FIXType.String;

		// Token: 0x04000B84 RID: 2948
		public const FIXType InvestorCountryOfResidence = FIXType.String;

		// Token: 0x04000B85 RID: 2949
		public const FIXType PaymentRef = FIXType.String;

		// Token: 0x04000B86 RID: 2950
		public const FIXType DistribPaymentMethod = FIXType.Int;

		// Token: 0x04000B87 RID: 2951
		public const FIXType CashDistribCurr = FIXType.Double;

		// Token: 0x04000B88 RID: 2952
		public const FIXType CommCurrency = FIXType.Double;

		// Token: 0x04000B89 RID: 2953
		public const FIXType CancellationRights = FIXType.Char;

		// Token: 0x04000B8A RID: 2954
		public const FIXType MoneyLaunderingStatus = FIXType.Char;

		// Token: 0x04000B8B RID: 2955
		public const FIXType MailingInst = FIXType.String;

		// Token: 0x04000B8C RID: 2956
		public const FIXType TransBkdTime = FIXType.DateTime;

		// Token: 0x04000B8D RID: 2957
		public const FIXType ExecPriceType = FIXType.Char;

		// Token: 0x04000B8E RID: 2958
		public const FIXType ExecPriceAdjustment = FIXType.Double;

		// Token: 0x04000B8F RID: 2959
		public const FIXType DateOfBirth = FIXType.DateTime;

		// Token: 0x04000B90 RID: 2960
		public const FIXType TradeReportTransType = FIXType.Int;

		// Token: 0x04000B91 RID: 2961
		public const FIXType CardHolderName = FIXType.String;

		// Token: 0x04000B92 RID: 2962
		public const FIXType CardNumber = FIXType.String;

		// Token: 0x04000B93 RID: 2963
		public const FIXType CardExpDate = FIXType.DateTime;

		// Token: 0x04000B94 RID: 2964
		public const FIXType CardIssNum = FIXType.String;

		// Token: 0x04000B95 RID: 2965
		public const FIXType PaymentMethod = FIXType.Int;

		// Token: 0x04000B96 RID: 2966
		public const FIXType RegistAcctType = FIXType.String;

		// Token: 0x04000B97 RID: 2967
		public const FIXType Designation = FIXType.String;

		// Token: 0x04000B98 RID: 2968
		public const FIXType TaxAdvantageType = FIXType.Int;

		// Token: 0x04000B99 RID: 2969
		public const FIXType RegistRejReasonText = FIXType.String;

		// Token: 0x04000B9A RID: 2970
		public const FIXType FundRenewWaiv = FIXType.Char;

		// Token: 0x04000B9B RID: 2971
		public const FIXType CashDistribAgentName = FIXType.String;

		// Token: 0x04000B9C RID: 2972
		public const FIXType CashDistribAgentCode = FIXType.String;

		// Token: 0x04000B9D RID: 2973
		public const FIXType CashDistribAgentAcctNumber = FIXType.String;

		// Token: 0x04000B9E RID: 2974
		public const FIXType CashDistribPayRef = FIXType.String;

		// Token: 0x04000B9F RID: 2975
		public const FIXType CashDistribAgentAcctName = FIXType.String;

		// Token: 0x04000BA0 RID: 2976
		public const FIXType CardStartDate = FIXType.DateTime;

		// Token: 0x04000BA1 RID: 2977
		public const FIXType PaymentDate = FIXType.DateTime;

		// Token: 0x04000BA2 RID: 2978
		public const FIXType PaymentRemitterID = FIXType.String;

		// Token: 0x04000BA3 RID: 2979
		public const FIXType RegistStatus = FIXType.Char;

		// Token: 0x04000BA4 RID: 2980
		public const FIXType RegistRejReasonCode = FIXType.Int;

		// Token: 0x04000BA5 RID: 2981
		public const FIXType RegistRefID = FIXType.String;

		// Token: 0x04000BA6 RID: 2982
		public const FIXType RegistDtls = FIXType.String;

		// Token: 0x04000BA7 RID: 2983
		public const FIXType NoDistribInsts = FIXType.Int;

		// Token: 0x04000BA8 RID: 2984
		public const FIXType RegistEmail = FIXType.String;

		// Token: 0x04000BA9 RID: 2985
		public const FIXType DistribPercentage = FIXType.Double;

		// Token: 0x04000BAA RID: 2986
		public const FIXType RegistID = FIXType.String;

		// Token: 0x04000BAB RID: 2987
		public const FIXType RegistTransType = FIXType.Char;

		// Token: 0x04000BAC RID: 2988
		public const FIXType ExecValuationPoint = FIXType.DateTime;

		// Token: 0x04000BAD RID: 2989
		public const FIXType OrderPercent = FIXType.Double;

		// Token: 0x04000BAE RID: 2990
		public const FIXType OwnershipType = FIXType.Char;

		// Token: 0x04000BAF RID: 2991
		public const FIXType NoContAmts = FIXType.Int;

		// Token: 0x04000BB0 RID: 2992
		public const FIXType ContAmtType = FIXType.Int;

		// Token: 0x04000BB1 RID: 2993
		public const FIXType ContAmtValue = FIXType.Double;

		// Token: 0x04000BB2 RID: 2994
		public const FIXType ContAmtCurr = FIXType.Double;

		// Token: 0x04000BB3 RID: 2995
		public const FIXType OwnerType = FIXType.Int;

		// Token: 0x04000BB4 RID: 2996
		public const FIXType PartySubID = FIXType.String;

		// Token: 0x04000BB5 RID: 2997
		public const FIXType NestedPartyID = FIXType.String;

		// Token: 0x04000BB6 RID: 2998
		public const FIXType NestedPartyIDSource = FIXType.Char;

		// Token: 0x04000BB7 RID: 2999
		public const FIXType SecondaryClOrdID = FIXType.String;

		// Token: 0x04000BB8 RID: 3000
		public const FIXType SecondaryExecID = FIXType.String;

		// Token: 0x04000BB9 RID: 3001
		public const FIXType OrderCapacity = FIXType.Char;

		// Token: 0x04000BBA RID: 3002
		public const FIXType OrderRestrictions = FIXType.String;

		// Token: 0x04000BBB RID: 3003
		public const FIXType MassCancelRequestType = FIXType.Char;

		// Token: 0x04000BBC RID: 3004
		public const FIXType MassCancelResponse = FIXType.Char;

		// Token: 0x04000BBD RID: 3005
		public const FIXType MassCancelRejectReason = FIXType.Char;

		// Token: 0x04000BBE RID: 3006
		public const FIXType TotalAffectedOrders = FIXType.Int;

		// Token: 0x04000BBF RID: 3007
		public const FIXType NoAffectedOrders = FIXType.Int;

		// Token: 0x04000BC0 RID: 3008
		public const FIXType AffectedOrderID = FIXType.String;

		// Token: 0x04000BC1 RID: 3009
		public const FIXType AffectedSecondaryOrderID = FIXType.String;

		// Token: 0x04000BC2 RID: 3010
		public const FIXType QuoteType = FIXType.Int;

		// Token: 0x04000BC3 RID: 3011
		public const FIXType NestedPartyRole = FIXType.Int;

		// Token: 0x04000BC4 RID: 3012
		public const FIXType NoNestedPartyIDs = FIXType.Int;

		// Token: 0x04000BC5 RID: 3013
		public const FIXType TotalAccruedInterestAmt = FIXType.Double;

		// Token: 0x04000BC6 RID: 3014
		public const FIXType MaturityDate = FIXType.DateTime;

		// Token: 0x04000BC7 RID: 3015
		public const FIXType UnderlyingMaturityDate = FIXType.DateTime;

		// Token: 0x04000BC8 RID: 3016
		public const FIXType InstrRegistry = FIXType.String;

		// Token: 0x04000BC9 RID: 3017
		public const FIXType CashMargin = FIXType.Char;

		// Token: 0x04000BCA RID: 3018
		public const FIXType NestedPartySubID = FIXType.String;

		// Token: 0x04000BCB RID: 3019
		public const FIXType Scope = FIXType.String;

		// Token: 0x04000BCC RID: 3020
		public const FIXType MDImplicitDelete = FIXType.Bool;

		// Token: 0x04000BCD RID: 3021
		public const FIXType CrossID = FIXType.String;

		// Token: 0x04000BCE RID: 3022
		public const FIXType CrossType = FIXType.Int;

		// Token: 0x04000BCF RID: 3023
		public const FIXType CrossPrioritization = FIXType.Int;

		// Token: 0x04000BD0 RID: 3024
		public const FIXType OrigCrossID = FIXType.String;

		// Token: 0x04000BD1 RID: 3025
		public const FIXType NoSides = FIXType.Int;

		// Token: 0x04000BD2 RID: 3026
		public const FIXType Username = FIXType.String;

		// Token: 0x04000BD3 RID: 3027
		public const FIXType Password = FIXType.String;

		// Token: 0x04000BD4 RID: 3028
		public const FIXType NoLegs = FIXType.Int;

		// Token: 0x04000BD5 RID: 3029
		public const FIXType LegCurrency = FIXType.Double;

		// Token: 0x04000BD6 RID: 3030
		public const FIXType TotNoSecurityTypes = FIXType.Int;

		// Token: 0x04000BD7 RID: 3031
		public const FIXType NoSecurityTypes = FIXType.Int;

		// Token: 0x04000BD8 RID: 3032
		public const FIXType SecurityListRequestType = FIXType.Int;

		// Token: 0x04000BD9 RID: 3033
		public const FIXType SecurityRequestResult = FIXType.Int;

		// Token: 0x04000BDA RID: 3034
		public const FIXType RoundLot = FIXType.Double;

		// Token: 0x04000BDB RID: 3035
		public const FIXType MinTradeVol = FIXType.Double;

		// Token: 0x04000BDC RID: 3036
		public const FIXType MultiLegRptTypeReq = FIXType.Int;

		// Token: 0x04000BDD RID: 3037
		public const FIXType LegPositionEffect = FIXType.Char;

		// Token: 0x04000BDE RID: 3038
		public const FIXType LegCoveredOrUncovered = FIXType.Int;

		// Token: 0x04000BDF RID: 3039
		public const FIXType LegPrice = FIXType.Double;

		// Token: 0x04000BE0 RID: 3040
		public const FIXType TradSesStatusRejReason = FIXType.Int;

		// Token: 0x04000BE1 RID: 3041
		public const FIXType TradeRequestID = FIXType.String;

		// Token: 0x04000BE2 RID: 3042
		public const FIXType TradeRequestType = FIXType.Int;

		// Token: 0x04000BE3 RID: 3043
		public const FIXType PreviouslyReported = FIXType.Bool;

		// Token: 0x04000BE4 RID: 3044
		public const FIXType TradeReportID = FIXType.String;

		// Token: 0x04000BE5 RID: 3045
		public const FIXType TradeReportRefID = FIXType.String;

		// Token: 0x04000BE6 RID: 3046
		public const FIXType MatchStatus = FIXType.Char;

		// Token: 0x04000BE7 RID: 3047
		public const FIXType MatchType = FIXType.String;

		// Token: 0x04000BE8 RID: 3048
		public const FIXType OddLot = FIXType.Bool;

		// Token: 0x04000BE9 RID: 3049
		public const FIXType NoClearingInstructions = FIXType.Int;

		// Token: 0x04000BEA RID: 3050
		public const FIXType ClearingInstruction = FIXType.Int;

		// Token: 0x04000BEB RID: 3051
		public const FIXType TradeInputSource = FIXType.String;

		// Token: 0x04000BEC RID: 3052
		public const FIXType TradeInputDevice = FIXType.String;

		// Token: 0x04000BED RID: 3053
		public const FIXType NoDates = FIXType.Int;

		// Token: 0x04000BEE RID: 3054
		public const FIXType AccountType = FIXType.Int;

		// Token: 0x04000BEF RID: 3055
		public const FIXType CustOrderCapacity = FIXType.Int;

		// Token: 0x04000BF0 RID: 3056
		public const FIXType ClOrdLinkID = FIXType.String;

		// Token: 0x04000BF1 RID: 3057
		public const FIXType MassStatusReqID = FIXType.String;

		// Token: 0x04000BF2 RID: 3058
		public const FIXType MassStatusReqType = FIXType.Int;

		// Token: 0x04000BF3 RID: 3059
		public const FIXType OrigOrdModTime = FIXType.DateTime;

		// Token: 0x04000BF4 RID: 3060
		public const FIXType LegSettlType = FIXType.Char;

		// Token: 0x04000BF5 RID: 3061
		public const FIXType LegSettlDate = FIXType.DateTime;

		// Token: 0x04000BF6 RID: 3062
		public const FIXType DayBookingInst = FIXType.Char;

		// Token: 0x04000BF7 RID: 3063
		public const FIXType BookingUnit = FIXType.Char;

		// Token: 0x04000BF8 RID: 3064
		public const FIXType PreallocMethod = FIXType.Char;

		// Token: 0x04000BF9 RID: 3065
		public const FIXType UnderlyingCountryOfIssue = FIXType.String;

		// Token: 0x04000BFA RID: 3066
		public const FIXType UnderlyingStateOrProvinceOfIssue = FIXType.String;

		// Token: 0x04000BFB RID: 3067
		public const FIXType UnderlyingLocaleOfIssue = FIXType.String;

		// Token: 0x04000BFC RID: 3068
		public const FIXType UnderlyingInstrRegistry = FIXType.String;

		// Token: 0x04000BFD RID: 3069
		public const FIXType LegCountryOfIssue = FIXType.String;

		// Token: 0x04000BFE RID: 3070
		public const FIXType LegStateOrProvinceOfIssue = FIXType.String;

		// Token: 0x04000BFF RID: 3071
		public const FIXType LegLocaleOfIssue = FIXType.String;

		// Token: 0x04000C00 RID: 3072
		public const FIXType LegInstrRegistry = FIXType.String;

		// Token: 0x04000C01 RID: 3073
		public const FIXType LegSymbol = FIXType.String;

		// Token: 0x04000C02 RID: 3074
		public const FIXType LegSymbolSfx = FIXType.String;

		// Token: 0x04000C03 RID: 3075
		public const FIXType LegSecurityID = FIXType.String;

		// Token: 0x04000C04 RID: 3076
		public const FIXType LegSecurityIDSource = FIXType.String;

		// Token: 0x04000C05 RID: 3077
		public const FIXType NoLegSecurityAltID = FIXType.String;

		// Token: 0x04000C06 RID: 3078
		public const FIXType LegSecurityAltID = FIXType.String;

		// Token: 0x04000C07 RID: 3079
		public const FIXType LegSecurityAltIDSource = FIXType.String;

		// Token: 0x04000C08 RID: 3080
		public const FIXType LegProduct = FIXType.Int;

		// Token: 0x04000C09 RID: 3081
		public const FIXType LegCFICode = FIXType.String;

		// Token: 0x04000C0A RID: 3082
		public const FIXType LegSecurityType = FIXType.String;

		// Token: 0x04000C0B RID: 3083
		public const FIXType LegMaturityMonthYear = FIXType.String;

		// Token: 0x04000C0C RID: 3084
		public const FIXType LegMaturityDate = FIXType.DateTime;

		// Token: 0x04000C0D RID: 3085
		public const FIXType LegStrikePrice = FIXType.Double;

		// Token: 0x04000C0E RID: 3086
		public const FIXType LegOptAttribute = FIXType.Char;

		// Token: 0x04000C0F RID: 3087
		public const FIXType LegContractMultiplier = FIXType.Double;

		// Token: 0x04000C10 RID: 3088
		public const FIXType LegCouponRate = FIXType.Double;

		// Token: 0x04000C11 RID: 3089
		public const FIXType LegSecurityExchange = FIXType.String;

		// Token: 0x04000C12 RID: 3090
		public const FIXType LegIssuer = FIXType.String;

		// Token: 0x04000C13 RID: 3091
		public const FIXType EncodedLegIssuerLen = FIXType.Int;

		// Token: 0x04000C14 RID: 3092
		public const FIXType EncodedLegIssuer = FIXType.String;

		// Token: 0x04000C15 RID: 3093
		public const FIXType LegSecurityDesc = FIXType.String;

		// Token: 0x04000C16 RID: 3094
		public const FIXType EncodedLegSecurityDescLen = FIXType.Int;

		// Token: 0x04000C17 RID: 3095
		public const FIXType EncodedLegSecurityDesc = FIXType.String;

		// Token: 0x04000C18 RID: 3096
		public const FIXType LegRatioQty = FIXType.Double;

		// Token: 0x04000C19 RID: 3097
		public const FIXType LegSide = FIXType.Char;

		// Token: 0x04000C1A RID: 3098
		public const FIXType TradingSessionSubID = FIXType.String;

		// Token: 0x04000C1B RID: 3099
		public const FIXType AllocType = FIXType.Int;

		// Token: 0x04000C1C RID: 3100
		public const FIXType NoHops = FIXType.Int;

		// Token: 0x04000C1D RID: 3101
		public const FIXType HopCompID = FIXType.String;

		// Token: 0x04000C1E RID: 3102
		public const FIXType HopSendingTime = FIXType.DateTime;

		// Token: 0x04000C1F RID: 3103
		public const FIXType HopRefID = FIXType.Int;

		// Token: 0x04000C20 RID: 3104
		public const FIXType MidPx = FIXType.Double;

		// Token: 0x04000C21 RID: 3105
		public const FIXType BidYield = FIXType.Double;

		// Token: 0x04000C22 RID: 3106
		public const FIXType MidYield = FIXType.Double;

		// Token: 0x04000C23 RID: 3107
		public const FIXType OfferYield = FIXType.Double;

		// Token: 0x04000C24 RID: 3108
		public const FIXType ClearingFeeIndicator = FIXType.String;

		// Token: 0x04000C25 RID: 3109
		public const FIXType WorkingIndicator = FIXType.Bool;

		// Token: 0x04000C26 RID: 3110
		public const FIXType LegLastPx = FIXType.Double;

		// Token: 0x04000C27 RID: 3111
		public const FIXType PriorityIndicator = FIXType.Int;

		// Token: 0x04000C28 RID: 3112
		public const FIXType PriceImprovement = FIXType.Double;

		// Token: 0x04000C29 RID: 3113
		public const FIXType Price2 = FIXType.Double;

		// Token: 0x04000C2A RID: 3114
		public const FIXType LastForwardPoints2 = FIXType.Double;

		// Token: 0x04000C2B RID: 3115
		public const FIXType BidForwardPoints2 = FIXType.Double;

		// Token: 0x04000C2C RID: 3116
		public const FIXType OfferForwardPoints2 = FIXType.Double;

		// Token: 0x04000C2D RID: 3117
		public const FIXType RFQReqID = FIXType.String;

		// Token: 0x04000C2E RID: 3118
		public const FIXType MktBidPx = FIXType.Double;

		// Token: 0x04000C2F RID: 3119
		public const FIXType MktOfferPx = FIXType.Double;

		// Token: 0x04000C30 RID: 3120
		public const FIXType MinBidSize = FIXType.Double;

		// Token: 0x04000C31 RID: 3121
		public const FIXType MinOfferSize = FIXType.Double;

		// Token: 0x04000C32 RID: 3122
		public const FIXType QuoteStatusReqID = FIXType.String;

		// Token: 0x04000C33 RID: 3123
		public const FIXType LegalConfirm = FIXType.Bool;

		// Token: 0x04000C34 RID: 3124
		public const FIXType UnderlyingLastPx = FIXType.Double;

		// Token: 0x04000C35 RID: 3125
		public const FIXType UnderlyingLastQty = FIXType.Double;

		// Token: 0x04000C36 RID: 3126
		public const FIXType SecDefStatus = FIXType.Int;

		// Token: 0x04000C37 RID: 3127
		public const FIXType LegRefID = FIXType.String;

		// Token: 0x04000C38 RID: 3128
		public const FIXType ContraLegRefID = FIXType.String;

		// Token: 0x04000C39 RID: 3129
		public const FIXType SettlCurrBidFxRate = FIXType.Double;

		// Token: 0x04000C3A RID: 3130
		public const FIXType SettlCurrOfferFxRate = FIXType.Double;

		// Token: 0x04000C3B RID: 3131
		public const FIXType QuoteRequestRejectReason = FIXType.Int;

		// Token: 0x04000C3C RID: 3132
		public const FIXType SideComplianceID = FIXType.String;

		// Token: 0x04000C3D RID: 3133
		public const FIXType AcctIDSource = FIXType.Int;

		// Token: 0x04000C3E RID: 3134
		public const FIXType AllocAcctIDSource = FIXType.Int;

		// Token: 0x04000C3F RID: 3135
		public const FIXType BenchmarkPrice = FIXType.Double;

		// Token: 0x04000C40 RID: 3136
		public const FIXType BenchmarkPriceType = FIXType.Int;

		// Token: 0x04000C41 RID: 3137
		public const FIXType ConfirmID = FIXType.String;

		// Token: 0x04000C42 RID: 3138
		public const FIXType ConfirmStatus = FIXType.Int;

		// Token: 0x04000C43 RID: 3139
		public const FIXType ConfirmTransType = FIXType.Int;

		// Token: 0x04000C44 RID: 3140
		public const FIXType ContractSettlMonth = FIXType.String;

		// Token: 0x04000C45 RID: 3141
		public const FIXType DeliveryForm = FIXType.Int;

		// Token: 0x04000C46 RID: 3142
		public const FIXType LastParPx = FIXType.Double;

		// Token: 0x04000C47 RID: 3143
		public const FIXType NoLegAllocs = FIXType.Int;

		// Token: 0x04000C48 RID: 3144
		public const FIXType LegAllocAccount = FIXType.String;

		// Token: 0x04000C49 RID: 3145
		public const FIXType LegIndividualAllocID = FIXType.String;

		// Token: 0x04000C4A RID: 3146
		public const FIXType LegAllocQty = FIXType.Double;

		// Token: 0x04000C4B RID: 3147
		public const FIXType LegAllocAcctIDSource = FIXType.String;

		// Token: 0x04000C4C RID: 3148
		public const FIXType LegSettlCurrency = FIXType.Double;

		// Token: 0x04000C4D RID: 3149
		public const FIXType LegBenchmarkCurveCurrency = FIXType.Double;

		// Token: 0x04000C4E RID: 3150
		public const FIXType LegBenchmarkCurveName = FIXType.String;

		// Token: 0x04000C4F RID: 3151
		public const FIXType LegBenchmarkCurvePoint = FIXType.String;

		// Token: 0x04000C50 RID: 3152
		public const FIXType LegBenchmarkPrice = FIXType.Double;

		// Token: 0x04000C51 RID: 3153
		public const FIXType LegBenchmarkPriceType = FIXType.Int;

		// Token: 0x04000C52 RID: 3154
		public const FIXType LegBidPx = FIXType.Double;

		// Token: 0x04000C53 RID: 3155
		public const FIXType LegIOIQty = FIXType.String;

		// Token: 0x04000C54 RID: 3156
		public const FIXType NoLegStipulations = FIXType.Int;

		// Token: 0x04000C55 RID: 3157
		public const FIXType LegOfferPx = FIXType.Double;

		// Token: 0x04000C56 RID: 3158
		public const FIXType LegOrderQty = FIXType.Double;

		// Token: 0x04000C57 RID: 3159
		public const FIXType LegPriceType = FIXType.Int;

		// Token: 0x04000C58 RID: 3160
		public const FIXType LegQty = FIXType.Double;

		// Token: 0x04000C59 RID: 3161
		public const FIXType LegStipulationType = FIXType.String;

		// Token: 0x04000C5A RID: 3162
		public const FIXType LegStipulationValue = FIXType.String;

		// Token: 0x04000C5B RID: 3163
		public const FIXType LegSwapType = FIXType.Int;

		// Token: 0x04000C5C RID: 3164
		public const FIXType Pool = FIXType.String;

		// Token: 0x04000C5D RID: 3165
		public const FIXType QuotePriceType = FIXType.Int;

		// Token: 0x04000C5E RID: 3166
		public const FIXType QuoteRespID = FIXType.String;

		// Token: 0x04000C5F RID: 3167
		public const FIXType QuoteRespType = FIXType.Int;

		// Token: 0x04000C60 RID: 3168
		public const FIXType QuoteQualifier = FIXType.Char;

		// Token: 0x04000C61 RID: 3169
		public const FIXType YieldRedemptionDate = FIXType.DateTime;

		// Token: 0x04000C62 RID: 3170
		public const FIXType YieldRedemptionPrice = FIXType.Double;

		// Token: 0x04000C63 RID: 3171
		public const FIXType YieldRedemptionPriceType = FIXType.Int;

		// Token: 0x04000C64 RID: 3172
		public const FIXType BenchmarkSecurityID = FIXType.String;

		// Token: 0x04000C65 RID: 3173
		public const FIXType ReversalIndicator = FIXType.Bool;

		// Token: 0x04000C66 RID: 3174
		public const FIXType YieldCalcDate = FIXType.DateTime;

		// Token: 0x04000C67 RID: 3175
		public const FIXType NoPositions = FIXType.Int;

		// Token: 0x04000C68 RID: 3176
		public const FIXType PosType = FIXType.String;

		// Token: 0x04000C69 RID: 3177
		public const FIXType LongQty = FIXType.Double;

		// Token: 0x04000C6A RID: 3178
		public const FIXType ShortQty = FIXType.Double;

		// Token: 0x04000C6B RID: 3179
		public const FIXType PosQtyStatus = FIXType.Int;

		// Token: 0x04000C6C RID: 3180
		public const FIXType PosAmtType = FIXType.String;

		// Token: 0x04000C6D RID: 3181
		public const FIXType PosAmt = FIXType.Double;

		// Token: 0x04000C6E RID: 3182
		public const FIXType PosTransType = FIXType.Int;

		// Token: 0x04000C6F RID: 3183
		public const FIXType PosReqID = FIXType.String;

		// Token: 0x04000C70 RID: 3184
		public const FIXType NoUnderlyings = FIXType.Int;

		// Token: 0x04000C71 RID: 3185
		public const FIXType PosMaintAction = FIXType.Int;

		// Token: 0x04000C72 RID: 3186
		public const FIXType OrigPosReqRefID = FIXType.String;

		// Token: 0x04000C73 RID: 3187
		public const FIXType PosMaintRptRefID = FIXType.String;

		// Token: 0x04000C74 RID: 3188
		public const FIXType ClearingBusinessDate = FIXType.DateTime;

		// Token: 0x04000C75 RID: 3189
		public const FIXType SettlSessID = FIXType.String;

		// Token: 0x04000C76 RID: 3190
		public const FIXType SettlSessSubID = FIXType.String;

		// Token: 0x04000C77 RID: 3191
		public const FIXType AdjustmentType = FIXType.Int;

		// Token: 0x04000C78 RID: 3192
		public const FIXType ContraryInstructionIndicator = FIXType.Bool;

		// Token: 0x04000C79 RID: 3193
		public const FIXType PriorSpreadIndicator = FIXType.Bool;

		// Token: 0x04000C7A RID: 3194
		public const FIXType PosMaintRptID = FIXType.String;

		// Token: 0x04000C7B RID: 3195
		public const FIXType PosMaintStatus = FIXType.Int;

		// Token: 0x04000C7C RID: 3196
		public const FIXType PosMaintResult = FIXType.Int;

		// Token: 0x04000C7D RID: 3197
		public const FIXType PosReqType = FIXType.Int;

		// Token: 0x04000C7E RID: 3198
		public const FIXType ResponseTransportType = FIXType.Int;

		// Token: 0x04000C7F RID: 3199
		public const FIXType ResponseDestination = FIXType.String;

		// Token: 0x04000C80 RID: 3200
		public const FIXType TotalNumPosReports = FIXType.Int;

		// Token: 0x04000C81 RID: 3201
		public const FIXType PosReqResult = FIXType.Int;

		// Token: 0x04000C82 RID: 3202
		public const FIXType PosReqStatus = FIXType.Int;

		// Token: 0x04000C83 RID: 3203
		public const FIXType SettlPrice = FIXType.Double;

		// Token: 0x04000C84 RID: 3204
		public const FIXType SettlPriceType = FIXType.Int;

		// Token: 0x04000C85 RID: 3205
		public const FIXType UnderlyingSettlPrice = FIXType.Double;

		// Token: 0x04000C86 RID: 3206
		public const FIXType UnderlyingSettlPriceType = FIXType.Int;

		// Token: 0x04000C87 RID: 3207
		public const FIXType PriorSettlPrice = FIXType.Double;

		// Token: 0x04000C88 RID: 3208
		public const FIXType NoQuoteQualifiers = FIXType.Int;

		// Token: 0x04000C89 RID: 3209
		public const FIXType AllocSettlCurrency = FIXType.Double;

		// Token: 0x04000C8A RID: 3210
		public const FIXType AllocSettlCurrAmt = FIXType.Double;

		// Token: 0x04000C8B RID: 3211
		public const FIXType InterestAtMaturity = FIXType.Double;

		// Token: 0x04000C8C RID: 3212
		public const FIXType LegDatedDate = FIXType.DateTime;

		// Token: 0x04000C8D RID: 3213
		public const FIXType LegPool = FIXType.String;

		// Token: 0x04000C8E RID: 3214
		public const FIXType AllocInterestAtMaturity = FIXType.Double;

		// Token: 0x04000C8F RID: 3215
		public const FIXType AllocAccruedInterestAmt = FIXType.Double;

		// Token: 0x04000C90 RID: 3216
		public const FIXType DeliveryDate = FIXType.DateTime;

		// Token: 0x04000C91 RID: 3217
		public const FIXType AssignmentMethod = FIXType.Char;

		// Token: 0x04000C92 RID: 3218
		public const FIXType AssignmentUnit = FIXType.Double;

		// Token: 0x04000C93 RID: 3219
		public const FIXType OpenInterest = FIXType.Double;

		// Token: 0x04000C94 RID: 3220
		public const FIXType ExerciseMethod = FIXType.Char;

		// Token: 0x04000C95 RID: 3221
		public const FIXType TotNumTradeReports = FIXType.Int;

		// Token: 0x04000C96 RID: 3222
		public const FIXType TradeRequestResult = FIXType.Int;

		// Token: 0x04000C97 RID: 3223
		public const FIXType TradeRequestStatus = FIXType.Int;

		// Token: 0x04000C98 RID: 3224
		public const FIXType TradeReportRejectReason = FIXType.Int;

		// Token: 0x04000C99 RID: 3225
		public const FIXType SideMultiLegReportingType = FIXType.Int;

		// Token: 0x04000C9A RID: 3226
		public const FIXType NoPosAmt = FIXType.Int;

		// Token: 0x04000C9B RID: 3227
		public const FIXType AutoAcceptIndicator = FIXType.Bool;

		// Token: 0x04000C9C RID: 3228
		public const FIXType AllocReportID = FIXType.String;

		// Token: 0x04000C9D RID: 3229
		public const FIXType NoNested2PartyIDs = FIXType.Int;

		// Token: 0x04000C9E RID: 3230
		public const FIXType Nested2PartyID = FIXType.String;

		// Token: 0x04000C9F RID: 3231
		public const FIXType Nested2PartyIDSource = FIXType.Char;

		// Token: 0x04000CA0 RID: 3232
		public const FIXType Nested2PartyRole = FIXType.Int;

		// Token: 0x04000CA1 RID: 3233
		public const FIXType Nested2PartySubID = FIXType.String;

		// Token: 0x04000CA2 RID: 3234
		public const FIXType BenchmarkSecurityIDSource = FIXType.String;

		// Token: 0x04000CA3 RID: 3235
		public const FIXType SecuritySubType = FIXType.String;

		// Token: 0x04000CA4 RID: 3236
		public const FIXType UnderlyingSecuritySubType = FIXType.String;

		// Token: 0x04000CA5 RID: 3237
		public const FIXType LegSecuritySubType = FIXType.String;

		// Token: 0x04000CA6 RID: 3238
		public const FIXType AllowableOneSidednessPct = FIXType.Double;

		// Token: 0x04000CA7 RID: 3239
		public const FIXType AllowableOneSidednessValue = FIXType.Double;

		// Token: 0x04000CA8 RID: 3240
		public const FIXType AllowableOneSidednessCurr = FIXType.Double;

		// Token: 0x04000CA9 RID: 3241
		public const FIXType NoTrdRegTimestamps = FIXType.Int;

		// Token: 0x04000CAA RID: 3242
		public const FIXType TrdRegTimestamp = FIXType.DateTime;

		// Token: 0x04000CAB RID: 3243
		public const FIXType TrdRegTimestampType = FIXType.Int;

		// Token: 0x04000CAC RID: 3244
		public const FIXType TrdRegTimestampOrigin = FIXType.String;

		// Token: 0x04000CAD RID: 3245
		public const FIXType ConfirmRefID = FIXType.String;

		// Token: 0x04000CAE RID: 3246
		public const FIXType ConfirmType = FIXType.Int;

		// Token: 0x04000CAF RID: 3247
		public const FIXType ConfirmRejReason = FIXType.Int;

		// Token: 0x04000CB0 RID: 3248
		public const FIXType BookingType = FIXType.Int;

		// Token: 0x04000CB1 RID: 3249
		public const FIXType IndividualAllocRejCode = FIXType.Int;

		// Token: 0x04000CB2 RID: 3250
		public const FIXType SettlInstMsgID = FIXType.String;

		// Token: 0x04000CB3 RID: 3251
		public const FIXType NoSettlInst = FIXType.Int;

		// Token: 0x04000CB4 RID: 3252
		public const FIXType LastUpdateTime = FIXType.DateTime;

		// Token: 0x04000CB5 RID: 3253
		public const FIXType AllocSettlInstType = FIXType.Int;

		// Token: 0x04000CB6 RID: 3254
		public const FIXType NoSettlPartyIDs = FIXType.Int;

		// Token: 0x04000CB7 RID: 3255
		public const FIXType SettlPartyID = FIXType.String;

		// Token: 0x04000CB8 RID: 3256
		public const FIXType SettlPartyIDSource = FIXType.Char;

		// Token: 0x04000CB9 RID: 3257
		public const FIXType SettlPartyRole = FIXType.Int;

		// Token: 0x04000CBA RID: 3258
		public const FIXType SettlPartySubID = FIXType.String;

		// Token: 0x04000CBB RID: 3259
		public const FIXType SettlPartySubIDType = FIXType.Int;

		// Token: 0x04000CBC RID: 3260
		public const FIXType DlvyInstType = FIXType.Char;

		// Token: 0x04000CBD RID: 3261
		public const FIXType TerminationType = FIXType.Int;

		// Token: 0x04000CBE RID: 3262
		public const FIXType NextExpectedMsgSeqNum = FIXType.Int;

		// Token: 0x04000CBF RID: 3263
		public const FIXType OrdStatusReqID = FIXType.String;

		// Token: 0x04000CC0 RID: 3264
		public const FIXType SettlInstReqID = FIXType.String;

		// Token: 0x04000CC1 RID: 3265
		public const FIXType SettlInstReqRejCode = FIXType.Int;

		// Token: 0x04000CC2 RID: 3266
		public const FIXType SecondaryAllocID = FIXType.String;

		// Token: 0x04000CC3 RID: 3267
		public const FIXType AllocReportType = FIXType.Int;

		// Token: 0x04000CC4 RID: 3268
		public const FIXType AllocReportRefID = FIXType.String;

		// Token: 0x04000CC5 RID: 3269
		public const FIXType AllocCancReplaceReason = FIXType.Int;

		// Token: 0x04000CC6 RID: 3270
		public const FIXType CopyMsgIndicator = FIXType.Bool;

		// Token: 0x04000CC7 RID: 3271
		public const FIXType AllocAccountType = FIXType.Int;

		// Token: 0x04000CC8 RID: 3272
		public const FIXType OrderAvgPx = FIXType.Double;

		// Token: 0x04000CC9 RID: 3273
		public const FIXType OrderBookingQty = FIXType.Double;

		// Token: 0x04000CCA RID: 3274
		public const FIXType NoSettlPartySubIDs = FIXType.Int;

		// Token: 0x04000CCB RID: 3275
		public const FIXType NoPartySubIDs = FIXType.Int;

		// Token: 0x04000CCC RID: 3276
		public const FIXType PartySubIDType = FIXType.Int;

		// Token: 0x04000CCD RID: 3277
		public const FIXType NoNestedPartySubIDs = FIXType.Int;

		// Token: 0x04000CCE RID: 3278
		public const FIXType NestedPartySubIDType = FIXType.Int;

		// Token: 0x04000CCF RID: 3279
		public const FIXType NoNested2PartySubIDs = FIXType.Int;

		// Token: 0x04000CD0 RID: 3280
		public const FIXType Nested2PartySubIDType = FIXType.Int;

		// Token: 0x04000CD1 RID: 3281
		public const FIXType AllocIntermedReqType = FIXType.Int;

		// Token: 0x04000CD2 RID: 3282
		public const FIXType UnderlyingPx = FIXType.Double;

		// Token: 0x04000CD3 RID: 3283
		public const FIXType PriceDelta = FIXType.Double;

		// Token: 0x04000CD4 RID: 3284
		public const FIXType ApplQueueMax = FIXType.Int;

		// Token: 0x04000CD5 RID: 3285
		public const FIXType ApplQueueDepth = FIXType.Int;

		// Token: 0x04000CD6 RID: 3286
		public const FIXType ApplQueueResolution = FIXType.Int;

		// Token: 0x04000CD7 RID: 3287
		public const FIXType ApplQueueAction = FIXType.Int;

		// Token: 0x04000CD8 RID: 3288
		public const FIXType NoAltMDSource = FIXType.Int;

		// Token: 0x04000CD9 RID: 3289
		public const FIXType AltMDSourceID = FIXType.String;

		// Token: 0x04000CDA RID: 3290
		public const FIXType SecondaryTradeReportID = FIXType.String;

		// Token: 0x04000CDB RID: 3291
		public const FIXType AvgPxIndicator = FIXType.Int;

		// Token: 0x04000CDC RID: 3292
		public const FIXType TradeLinkID = FIXType.String;

		// Token: 0x04000CDD RID: 3293
		public const FIXType OrderInputDevice = FIXType.String;

		// Token: 0x04000CDE RID: 3294
		public const FIXType UnderlyingTradingSessionID = FIXType.String;

		// Token: 0x04000CDF RID: 3295
		public const FIXType UnderlyingTradingSessionSubID = FIXType.String;

		// Token: 0x04000CE0 RID: 3296
		public const FIXType TradeLegRefID = FIXType.String;

		// Token: 0x04000CE1 RID: 3297
		public const FIXType ExchangeRule = FIXType.String;

		// Token: 0x04000CE2 RID: 3298
		public const FIXType TradeAllocIndicator = FIXType.Int;

		// Token: 0x04000CE3 RID: 3299
		public const FIXType ExpirationCycle = FIXType.Int;

		// Token: 0x04000CE4 RID: 3300
		public const FIXType TrdType = FIXType.Int;

		// Token: 0x04000CE5 RID: 3301
		public const FIXType TrdSubType = FIXType.Int;

		// Token: 0x04000CE6 RID: 3302
		public const FIXType TransferReason = FIXType.String;

		// Token: 0x04000CE7 RID: 3303
		public const FIXType AsgnReqID = FIXType.String;

		// Token: 0x04000CE8 RID: 3304
		public const FIXType TotNumAssignmentReports = FIXType.Int;

		// Token: 0x04000CE9 RID: 3305
		public const FIXType AsgnRptID = FIXType.String;

		// Token: 0x04000CEA RID: 3306
		public const FIXType ThresholdAmount = FIXType.Double;

		// Token: 0x04000CEB RID: 3307
		public const FIXType PegMoveType = FIXType.Int;

		// Token: 0x04000CEC RID: 3308
		public const FIXType PegOffsetType = FIXType.Int;

		// Token: 0x04000CED RID: 3309
		public const FIXType PegLimitType = FIXType.Int;

		// Token: 0x04000CEE RID: 3310
		public const FIXType PegRoundDirection = FIXType.Int;

		// Token: 0x04000CEF RID: 3311
		public const FIXType PeggedPrice = FIXType.Double;

		// Token: 0x04000CF0 RID: 3312
		public const FIXType PegScope = FIXType.Int;

		// Token: 0x04000CF1 RID: 3313
		public const FIXType DiscretionMoveType = FIXType.Int;

		// Token: 0x04000CF2 RID: 3314
		public const FIXType DiscretionOffsetType = FIXType.Int;

		// Token: 0x04000CF3 RID: 3315
		public const FIXType DiscretionLimitType = FIXType.Int;

		// Token: 0x04000CF4 RID: 3316
		public const FIXType DiscretionRoundDirection = FIXType.Int;

		// Token: 0x04000CF5 RID: 3317
		public const FIXType DiscretionPrice = FIXType.Double;

		// Token: 0x04000CF6 RID: 3318
		public const FIXType DiscretionScope = FIXType.Int;

		// Token: 0x04000CF7 RID: 3319
		public const FIXType TargetStrategy = FIXType.Int;

		// Token: 0x04000CF8 RID: 3320
		public const FIXType TargetStrategyParameters = FIXType.String;

		// Token: 0x04000CF9 RID: 3321
		public const FIXType ParticipationRate = FIXType.Double;

		// Token: 0x04000CFA RID: 3322
		public const FIXType TargetStrategyPerformance = FIXType.Double;

		// Token: 0x04000CFB RID: 3323
		public const FIXType LastLiquidityInd = FIXType.Int;

		// Token: 0x04000CFC RID: 3324
		public const FIXType PublishTrdIndicator = FIXType.Bool;

		// Token: 0x04000CFD RID: 3325
		public const FIXType ShortSaleReason = FIXType.Int;

		// Token: 0x04000CFE RID: 3326
		public const FIXType QtyType = FIXType.Int;

		// Token: 0x04000CFF RID: 3327
		public const FIXType SecondaryTrdType = FIXType.Int;

		// Token: 0x04000D00 RID: 3328
		public const FIXType TradeReportType = FIXType.Int;

		// Token: 0x04000D01 RID: 3329
		public const FIXType AllocNoOrdersType = FIXType.Int;

		// Token: 0x04000D02 RID: 3330
		public const FIXType SharedCommission = FIXType.Double;

		// Token: 0x04000D03 RID: 3331
		public const FIXType ConfirmReqID = FIXType.String;

		// Token: 0x04000D04 RID: 3332
		public const FIXType AvgParPx = FIXType.Double;

		// Token: 0x04000D05 RID: 3333
		public const FIXType ReportedPx = FIXType.Double;

		// Token: 0x04000D06 RID: 3334
		public const FIXType NoCapacities = FIXType.Int;

		// Token: 0x04000D07 RID: 3335
		public const FIXType OrderCapacityQty = FIXType.Double;

		// Token: 0x04000D08 RID: 3336
		public const FIXType NoEvents = FIXType.Int;

		// Token: 0x04000D09 RID: 3337
		public const FIXType EventType = FIXType.Int;

		// Token: 0x04000D0A RID: 3338
		public const FIXType EventDate = FIXType.DateTime;

		// Token: 0x04000D0B RID: 3339
		public const FIXType EventPx = FIXType.Double;

		// Token: 0x04000D0C RID: 3340
		public const FIXType EventText = FIXType.String;

		// Token: 0x04000D0D RID: 3341
		public const FIXType PctAtRisk = FIXType.Double;

		// Token: 0x04000D0E RID: 3342
		public const FIXType NoInstrAttrib = FIXType.Int;

		// Token: 0x04000D0F RID: 3343
		public const FIXType InstrAttribType = FIXType.Int;

		// Token: 0x04000D10 RID: 3344
		public const FIXType InstrAttribValue = FIXType.String;

		// Token: 0x04000D11 RID: 3345
		public const FIXType DatedDate = FIXType.DateTime;

		// Token: 0x04000D12 RID: 3346
		public const FIXType InterestAccrualDate = FIXType.DateTime;

		// Token: 0x04000D13 RID: 3347
		public const FIXType CPProgram = FIXType.Int;

		// Token: 0x04000D14 RID: 3348
		public const FIXType CPRegType = FIXType.String;

		// Token: 0x04000D15 RID: 3349
		public const FIXType UnderlyingCPProgram = FIXType.String;

		// Token: 0x04000D16 RID: 3350
		public const FIXType UnderlyingCPRegType = FIXType.String;

		// Token: 0x04000D17 RID: 3351
		public const FIXType UnderlyingQty = FIXType.Double;

		// Token: 0x04000D18 RID: 3352
		public const FIXType TrdMatchID = FIXType.String;

		// Token: 0x04000D19 RID: 3353
		public const FIXType SecondaryTradeReportRefID = FIXType.String;

		// Token: 0x04000D1A RID: 3354
		public const FIXType UnderlyingDirtyPrice = FIXType.Double;

		// Token: 0x04000D1B RID: 3355
		public const FIXType UnderlyingEndPrice = FIXType.Double;

		// Token: 0x04000D1C RID: 3356
		public const FIXType UnderlyingStartValue = FIXType.Double;

		// Token: 0x04000D1D RID: 3357
		public const FIXType UnderlyingCurrentValue = FIXType.Double;

		// Token: 0x04000D1E RID: 3358
		public const FIXType UnderlyingEndValue = FIXType.Double;

		// Token: 0x04000D1F RID: 3359
		public const FIXType NoUnderlyingStips = FIXType.Int;

		// Token: 0x04000D20 RID: 3360
		public const FIXType UnderlyingStipType = FIXType.String;

		// Token: 0x04000D21 RID: 3361
		public const FIXType UnderlyingStipValue = FIXType.String;

		// Token: 0x04000D22 RID: 3362
		public const FIXType MaturityNetMoney = FIXType.Double;

		// Token: 0x04000D23 RID: 3363
		public const FIXType MiscFeeBasis = FIXType.Int;

		// Token: 0x04000D24 RID: 3364
		public const FIXType TotNoAllocs = FIXType.Int;

		// Token: 0x04000D25 RID: 3365
		public const FIXType LastFragment = FIXType.Bool;

		// Token: 0x04000D26 RID: 3366
		public const FIXType CollReqID = FIXType.String;

		// Token: 0x04000D27 RID: 3367
		public const FIXType CollAsgnReason = FIXType.Int;

		// Token: 0x04000D28 RID: 3368
		public const FIXType CollInquiryQualifier = FIXType.Int;

		// Token: 0x04000D29 RID: 3369
		public const FIXType NoTrades = FIXType.Int;

		// Token: 0x04000D2A RID: 3370
		public const FIXType MarginRatio = FIXType.Double;

		// Token: 0x04000D2B RID: 3371
		public const FIXType MarginExcess = FIXType.Double;

		// Token: 0x04000D2C RID: 3372
		public const FIXType TotalNetValue = FIXType.Double;

		// Token: 0x04000D2D RID: 3373
		public const FIXType CashOutstanding = FIXType.Double;

		// Token: 0x04000D2E RID: 3374
		public const FIXType CollAsgnID = FIXType.String;

		// Token: 0x04000D2F RID: 3375
		public const FIXType CollAsgnTransType = FIXType.Int;

		// Token: 0x04000D30 RID: 3376
		public const FIXType CollRespID = FIXType.String;

		// Token: 0x04000D31 RID: 3377
		public const FIXType CollAsgnRespType = FIXType.Int;

		// Token: 0x04000D32 RID: 3378
		public const FIXType CollAsgnRejectReason = FIXType.Int;

		// Token: 0x04000D33 RID: 3379
		public const FIXType CollAsgnRefID = FIXType.String;

		// Token: 0x04000D34 RID: 3380
		public const FIXType CollRptID = FIXType.String;

		// Token: 0x04000D35 RID: 3381
		public const FIXType CollInquiryID = FIXType.String;

		// Token: 0x04000D36 RID: 3382
		public const FIXType CollStatus = FIXType.Int;

		// Token: 0x04000D37 RID: 3383
		public const FIXType TotNumReports = FIXType.Int;

		// Token: 0x04000D38 RID: 3384
		public const FIXType LastRptRequested = FIXType.Bool;

		// Token: 0x04000D39 RID: 3385
		public const FIXType AgreementDesc = FIXType.String;

		// Token: 0x04000D3A RID: 3386
		public const FIXType AgreementID = FIXType.String;

		// Token: 0x04000D3B RID: 3387
		public const FIXType AgreementDate = FIXType.DateTime;

		// Token: 0x04000D3C RID: 3388
		public const FIXType StartDate = FIXType.DateTime;

		// Token: 0x04000D3D RID: 3389
		public const FIXType EndDate = FIXType.DateTime;

		// Token: 0x04000D3E RID: 3390
		public const FIXType AgreementCurrency = FIXType.Double;

		// Token: 0x04000D3F RID: 3391
		public const FIXType DeliveryType = FIXType.Int;

		// Token: 0x04000D40 RID: 3392
		public const FIXType EndAccruedInterestAmt = FIXType.Double;

		// Token: 0x04000D41 RID: 3393
		public const FIXType StartCash = FIXType.Double;

		// Token: 0x04000D42 RID: 3394
		public const FIXType EndCash = FIXType.Double;

		// Token: 0x04000D43 RID: 3395
		public const FIXType UserRequestID = FIXType.String;

		// Token: 0x04000D44 RID: 3396
		public const FIXType UserRequestType = FIXType.Int;

		// Token: 0x04000D45 RID: 3397
		public const FIXType NewPassword = FIXType.String;

		// Token: 0x04000D46 RID: 3398
		public const FIXType UserStatus = FIXType.Int;

		// Token: 0x04000D47 RID: 3399
		public const FIXType UserStatusText = FIXType.String;

		// Token: 0x04000D48 RID: 3400
		public const FIXType StatusValue = FIXType.Int;

		// Token: 0x04000D49 RID: 3401
		public const FIXType StatusText = FIXType.String;

		// Token: 0x04000D4A RID: 3402
		public const FIXType RefCompID = FIXType.String;

		// Token: 0x04000D4B RID: 3403
		public const FIXType RefSubID = FIXType.String;

		// Token: 0x04000D4C RID: 3404
		public const FIXType NetworkResponseID = FIXType.String;

		// Token: 0x04000D4D RID: 3405
		public const FIXType NetworkRequestID = FIXType.String;

		// Token: 0x04000D4E RID: 3406
		public const FIXType LastNetworkResponseID = FIXType.String;

		// Token: 0x04000D4F RID: 3407
		public const FIXType NetworkRequestType = FIXType.Int;

		// Token: 0x04000D50 RID: 3408
		public const FIXType NoCompIDs = FIXType.Int;

		// Token: 0x04000D51 RID: 3409
		public const FIXType NetworkStatusResponseType = FIXType.Int;

		// Token: 0x04000D52 RID: 3410
		public const FIXType NoCollInquiryQualifier = FIXType.Int;

		// Token: 0x04000D53 RID: 3411
		public const FIXType TrdRptStatus = FIXType.Int;

		// Token: 0x04000D54 RID: 3412
		public const FIXType AffirmStatus = FIXType.Int;

		// Token: 0x04000D55 RID: 3413
		public const FIXType UnderlyingStrikeCurrency = FIXType.Double;

		// Token: 0x04000D56 RID: 3414
		public const FIXType LegStrikeCurrency = FIXType.Double;

		// Token: 0x04000D57 RID: 3415
		public const FIXType TimeBracket = FIXType.String;

		// Token: 0x04000D58 RID: 3416
		public const FIXType CollAction = FIXType.Int;

		// Token: 0x04000D59 RID: 3417
		public const FIXType CollInquiryStatus = FIXType.Int;

		// Token: 0x04000D5A RID: 3418
		public const FIXType CollInquiryResult = FIXType.Int;

		// Token: 0x04000D5B RID: 3419
		public const FIXType StrikeCurrency = FIXType.Double;

		// Token: 0x04000D5C RID: 3420
		public const FIXType NoNested3PartyIDs = FIXType.Int;

		// Token: 0x04000D5D RID: 3421
		public const FIXType Nested3PartyID = FIXType.String;

		// Token: 0x04000D5E RID: 3422
		public const FIXType Nested3PartyIDSource = FIXType.Char;

		// Token: 0x04000D5F RID: 3423
		public const FIXType Nested3PartyRole = FIXType.Int;

		// Token: 0x04000D60 RID: 3424
		public const FIXType NoNested3PartySubIDs = FIXType.Int;

		// Token: 0x04000D61 RID: 3425
		public const FIXType Nested3PartySubID = FIXType.String;

		// Token: 0x04000D62 RID: 3426
		public const FIXType Nested3PartySubIDType = FIXType.Int;

		// Token: 0x04000D63 RID: 3427
		public const FIXType LegContractSettlMonth = FIXType.String;

		// Token: 0x04000D64 RID: 3428
		public const FIXType LegInterestAccrualDate = FIXType.DateTime;
	}
}
