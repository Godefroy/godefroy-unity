﻿using System.Collections.Generic;
using UnityEngine;

public static class Font {
    public const int Height = 8;

    private static Dictionary<char, int[]> _chars = new Dictionary<char, int[]> {
        {
            ' ', new[] {
                3, // Columns
                0, 0, 0,
            }
        }, {
            ':', new[] {
                1,
                0,
                0,
                1,
                0,
                1,
            }
        }, {
            'A', new[] {
                3,
                0, 1, 0,
                1, 0, 1,
                1, 0, 1,
                1, 1, 1,
                1, 0, 1
            }
        }, {
            'B', new[] {
                3,
                1, 1, 0,
                1, 0, 1,
                1, 1, 0,
                1, 0, 1,
                1, 1, 0
            }
        }, {
            'C', new[] {
                3,
                0, 1, 1,
                1, 0, 0,
                1, 0, 0,
                1, 0, 0,
                0, 1, 1
            }
        }, {
            'D', new[] {
                3,
                1, 1, 0,
                1, 0, 1,
                1, 0, 1,
                1, 0, 1,
                1, 1, 0
            }
        }, {
            'E', new[] {
                3,
                1, 1, 1,
                1, 0, 0,
                1, 1, 1,
                1, 0, 0,
                1, 1, 1
            }
        }, {
            'F', new[] {
                3,
                1, 1, 1,
                1, 0, 0,
                1, 1, 0,
                1, 0, 0,
                1, 0, 0,
            }
        }, {
            'G', new[] {
                4,
                0, 1, 1, 0,
                1, 0, 0, 0,
                1, 0, 1, 1,
                1, 0, 0, 1,
                0, 1, 1, 0
            }
        }, {
            'H', new[] {
                3,
                1, 0, 1,
                1, 0, 1,
                1, 1, 1,
                1, 0, 1,
                1, 0, 1
            }
        }, {
            'I', new[] {
                3,
                1, 1, 1,
                0, 1, 0,
                0, 1, 0,
                0, 1, 0,
                1, 1, 1
            }
        }, {
            'J', new[] {
                3,
                1, 1, 1,
                0, 0, 1,
                0, 0, 1,
                1, 0, 1,
                1, 1, 1
            }
        }, {
            'K', new[] {
                4,
                1, 0, 0, 1,
                1, 0, 1, 0,
                1, 1, 0, 0,
                1, 0, 1, 0,
                1, 0, 0, 1
            }
        }, {
            'L', new[] {
                3,
                1, 0, 0,
                1, 0, 0,
                1, 0, 0,
                1, 0, 0,
                1, 1, 1
            }
        }, {
            'M', new[] {
                5,
                1, 1, 1, 1, 1,
                1, 0, 1, 0, 1,
                1, 0, 1, 0, 1,
                1, 0, 0, 0, 1,
                1, 0, 0, 0, 1
            }
        }, {
            'N', new[] {
                4,
                1, 0, 0, 1,
                1, 1, 0, 1,
                1, 0, 1, 1,
                1, 0, 0, 1,
                1, 0, 0, 1
            }
        }, {
            'O', new[] {
                3,
                1, 1, 1,
                1, 0, 1,
                1, 0, 1,
                1, 0, 1,
                1, 1, 1
            }
        }, {
            'P', new[] {
                3,
                1, 1, 1,
                1, 0, 1,
                1, 1, 1,
                1, 0, 0,
                1, 0, 0
            }
        }, {
            'Q', new[] {
                4,
                0, 1, 1, 0,
                1, 0, 0, 1,
                1, 0, 0, 1,
                1, 0, 1, 1,
                1, 1, 1, 1
            }
        }, {
            'R', new[] {
                3,
                1, 1, 0,
                1, 0, 1,
                1, 0, 1,
                1, 1, 0,
                1, 0, 1
            }
        }, {
            'S', new[] {
                3,
                1, 1, 1,
                1, 0, 0,
                1, 1, 1,
                0, 0, 1,
                1, 1, 1
            }
        }, {
            'T', new[] {
                3,
                1, 1, 1,
                0, 1, 0,
                0, 1, 0,
                0, 1, 0,
                0, 1, 0
            }
        }, {
            'U', new[] {
                3,
                1, 0, 1,
                1, 0, 1,
                1, 0, 1,
                1, 0, 1,
                1, 1, 1
            }
        }, {
            'V', new[] {
                5,
                1, 0, 0, 0, 1,
                1, 0, 0, 0, 1,
                0, 1, 0, 1, 0,
                0, 1, 0, 1, 0,
                0, 0, 1, 0, 0
            }
        }, {
            'W', new[] {
                5,
                1, 0, 0, 0, 1,
                1, 0, 0, 0, 1,
                1, 0, 0, 0, 1,
                1, 0, 1, 0, 1,
                0, 1, 0, 1, 0
            }
        }, {
            'X', new[] {
                5,
                1, 0, 0, 0, 1,
                0, 1, 0, 1, 0,
                0, 0, 1, 0, 0,
                0, 1, 0, 1, 0,
                1, 0, 0, 0, 1
            }
        }, {
            'Y', new[] {
                3,
                1, 0, 1,
                1, 0, 1,
                0, 1, 0,
                0, 1, 0,
                0, 1, 0
            }
        }, {
            'Z', new[] {
                5,
                1, 1, 1, 1, 1,
                0, 0, 0, 1, 0,
                0, 0, 1, 0, 0,
                0, 1, 0, 0, 0,
                1, 1, 1, 1, 1
            }
        }, {
            'a', new[] {
                3,
                0, 0, 0,
                1, 1, 0,
                0, 0, 1,
                1, 1, 1,
                1, 1, 1
            }
        }, {
            'b', new[] {
                3,
                1, 0, 0,
                1, 1, 0,
                1, 0, 1,
                1, 0, 1,
                1, 1, 0
            }
        }, {
            'c', new[] {
                3,
                0, 0, 0,
                0, 1, 1,
                1, 0, 0,
                1, 0, 0,
                0, 1, 1
            }
        }, {
            'd', new[] {
                3,
                0, 0, 1,
                0, 0, 1,
                0, 1, 1,
                1, 0, 1,
                0, 1, 1
            }
        }, {
            'e', new[] {
                3,
                0, 0, 0,
                0, 1, 0,
                1, 1, 1,
                1, 0, 0,
                1, 1, 1
            }
        }, {
            'f', new[] {
                2,
                0, 1,
                1, 0,
                1, 1,
                1, 0,
                1, 0,
            }
        }, {
            'g', new[] {
                3,
                0, 0, 0,
                0, 0, 0,
                0, 1, 1,
                1, 0, 1,
                0, 1, 1,
                0, 0, 1,
                1, 0, 1,
                0, 1, 0
            }
        }, {
            'h', new[] {
                3,
                1, 0, 0,
                1, 0, 0,
                1, 1, 0,
                1, 0, 1,
                1, 0, 1
            }
        }, {
            'i', new[] {
                1,
                1,
                0,
                1,
                1,
                1,
            }
        }, {
            'j', new[] {
                2,
                0, 1,
                0, 0,
                0, 1,
                1, 1,
                0, 1,
                0, 1,
                0, 1,
                1, 0
            }
        }, {
            'k', new[] {
                3,
                1, 0, 0,
                1, 0, 0,
                1, 0, 1,
                1, 1, 0,
                1, 0, 1,
            }
        }, {
            'l', new[] {
                2,
                1, 0,
                1, 0,
                1, 0,
                1, 0,
                1, 1,
            }
        }, {
            'm', new[] {
                5,
                0, 0, 0, 0, 0,
                0, 0, 0, 0, 0,
                1, 1, 0, 1, 0,
                1, 0, 1, 0, 1,
                1, 0, 1, 0, 1
            }
        }, {
            'n', new[] {
                3,
                0, 0, 0,
                0, 0, 0,
                1, 1, 0,
                1, 0, 1,
                1, 0, 1,
            }
        }, {
            'o', new[] {
                3,
                0, 0, 0,
                0, 0, 0,
                0, 1, 0,
                1, 0, 1,
                0, 1, 0,
            }
        }, {
            'p', new[] {
                3,
                0, 0, 0,
                0, 0, 0,
                1, 1, 0,
                1, 0, 1,
                1, 1, 0,
                1, 0, 0,
                1, 0, 0,
                1, 0, 0
            }
        }, {
            'q', new[] {
                3,
                0, 0, 0,
                0, 0, 0,
                0, 1, 1,
                1, 0, 1,
                0, 1, 1,
                0, 0, 1,
                0, 0, 1,
                0, 0, 1
            }
        }, {
            'r', new[] {
                3,
                0, 0, 0,
                0, 0, 0,
                1, 1, 1,
                1, 0, 0,
                1, 0, 0
            }
        }, {
            's', new[] {
                4,
                0, 0, 0, 0,
                0, 1, 0, 0,
                0, 1, 1, 0,
                0, 1, 0, 1,
                1, 1, 1, 0
            }
        }, {
            't', new[] {
                2,
                1, 0,
                1, 1,
                1, 0,
                1, 0,
                1, 1
            }
        }, {
            'u', new[] {
                3,
                0, 0, 0,
                0, 0, 0,
                1, 0, 1,
                1, 0, 1,
                1, 1, 1
            }
        }, {
            'v', new[] {
                3,
                0, 0, 0,
                0, 0, 0,
                1, 0, 1,
                1, 0, 1,
                0, 1, 0
            }
        }, {
            'w', new[] {
                5,
                0, 0, 0, 0, 0,
                0, 0, 0, 0, 0,
                1, 0, 0, 0, 1,
                1, 0, 1, 0, 1,
                0, 1, 0, 1, 0
            }
        }, {
            'x', new[] {
                3,
                0, 0, 0,
                0, 0, 0,
                1, 0, 1,
                0, 1, 0,
                1, 0, 1
            }
        }, {
            'y', new[] {
                3,
                0, 0, 0,
                0, 0, 0,
                1, 0, 1,
                1, 0, 1,
                0, 1, 0,
                0, 1, 0,
                0, 1, 0,
                1, 0, 0
            }
        }, {
            'z', new[] {
                3,
                0, 0, 0,
                0, 0, 0,
                1, 1, 1,
                0, 0, 1,
                0, 1, 1,
                0, 0, 1,
                1, 0, 1,
                0, 1, 0
            }
        },
    };

    public static FontChar GetFontChar(char character) {
        int[] data;
        if (_chars.TryGetValue(character, out data)) {
            var width = data[0];
            var pixels = new List<Vector2>();
            for (var i = 1; i < data.Length; i++) {
                if (data[i] == 0) continue;
                pixels.Add(new Vector2((i - 1) % width, -(i - 1) / width - 1));
            }
            return new FontChar(width, Height, pixels);
        }
        Debug.LogWarning("Char \"" + character + "\" not found in Font");
        return null;
    }
}